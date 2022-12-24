using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Codeplex.Data;
using System.Net.Http;
using WebSocket4Net;

namespace シンコメビュ
{
    public partial class Form1 : Form
    {
        private bool Is_connect = false;
        private bool ScrollStop = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //バージョン更新時の処理
            if (Properties.Settings.Default.IsUpgrade == false)
            {
                // Upgradeを実行する
                Properties.Settings.Default.Upgrade();

                // 「Upgradeを実行した」という情報を設定する
                Properties.Settings.Default.IsUpgrade = true;

                // 現行バージョンの設定を保存する
                Properties.Settings.Default.Save();
            }

            //横幅・高さの設定
            this.Width = Properties.Settings.Default.width;
            this.Height = Properties.Settings.Default.height;


            //ちらつき防止（コピペ
            System.Type dgvtype = typeof(DataGridView);

            // プロパティ設定の取得
            System.Reflection.PropertyInfo dgvPropertyInfo =
            dgvtype.GetProperty(
            "DoubleBuffered", System.Reflection.BindingFlags.Instance |
            System.Reflection.BindingFlags.NonPublic);

            // 対象のDataGridViewにtrueをセットする
            dgvPropertyInfo.SetValue(dataGridView1, true, null);

            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ColumnCount = 3;

            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;


            dataGridView1.Columns[0].Width = Properties.Settings.Default.width;
            dataGridView1.Columns[0].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.AllowUserToAddRows = false;
            //背景色変更
            dataGridView1.RowsDefaultCellStyle.BackColor = Color.White;
            //フォント変更
            dataGridView1.RowsDefaultCellStyle.Font = Properties.Settings.Default.font;
            //偶数行の背景色変更
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridView1.Columns[0].ContextMenuStrip = this.contextMenuStrip1;
        }
        //useridの抽出
        private string User_id()
        {
            if (userid_box.Text.Contains("twitcasting.tv"))
            {
                if (userid_box.Text.Contains("https://"))
                {
                    string rep = userid_box.Text.Replace("https://", "");
                    string rep2 = rep.Replace("twitcasting.tv/", "");
                    //Comment(rep2);
                    //Console.WriteLine(rep2);
                    return rep2;
                }
                else
                {
                    string rep = userid_box.Text.Replace("twitcasting.tv/", "");
                    //Console.WriteLine(rep);
                    return rep;
                }
            }
            else
            {
                string streaming = userid_box.Text;
                return streaming;

            }

        }

        //WebRequestの短縮化
        private string req(string url)
        {
            var wc = new WebClient();
            var downloaddata = wc.DownloadData(url);
            var enc = Encoding.UTF8.GetString(downloaddata);
            return enc;
        }

        //接続ボタンが押されたときの処理
        private void connect_button_Click(object sender, EventArgs e)
        {
            

            if (!Is_connect && userid_box.Text != "")
            {
                Console.WriteLine(User_id());
                //ユーザー存在チェックと配信中かチェック
                string latest = req("https://frontendapi.twitcasting.tv/users/" + User_id() + "/latest-movie");
                var js = DynamicJson.Parse(latest);
                if (js.IsDefined("error"))
                {
                    MessageBox.Show("エラー：" + js.error.message + "(" + js.error.code + ")", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    if (js.movie.is_on_live)
                    {
                        userid_box.Enabled = false;
                        connect_button.Text = "切断";
                        radio_new.Enabled = false;
                        radio_sub.Enabled = false;
                        radio_kansya.Enabled = false;
                        radio_other.Enabled = false;
                        Is_connect = true;
                        ws_connect();
                    }
                    else
                    {
                        MessageBox.Show("現在配信していません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            else
            {
                Is_connect = false;
                userid_box.Enabled = true;
                connect_button.Text = "接続";
                radio_new.Enabled = true;
                radio_sub.Enabled = true;
                radio_kansya.Enabled = true;
                radio_other.Enabled = true;
            }
        }

        //wsの接続
        private async void ws_connect()
        {
            string ws_ur = await ws_url();
            Console.WriteLine("ws_url->OK");

            Task tsk = Task.Run(() =>
            {
                var ws = new WebSocket(ws_ur);
                ws.MessageReceived += Ws_MessageReceived;
                ws.Open();

                while (true)
                {
                    if (!Is_connect)
                    {
                        break;
                    }
                }
                ws.Close();
            });
        }

        //wsのメッセージを処理
        private void Ws_MessageReceived(object sender, MessageReceivedEventArgs e)
        {
            string msg = e.Message;
            if(msg != "[]")
            {
                var js = DynamicJson.Parse(msg);
                for(int i = 0; js.IsDefined(i); i++)
                {
                    this.Invoke((MethodInvoker)(() => dataGridView1.Rows.Add(js[i].message, js[i].id, js[i].author.id)));
                    if (!ScrollStop)
                    {
                        this.Invoke((MethodInvoker)(() => dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.Rows.Count - 1));
                        this.Invoke((MethodInvoker)(() => ScrollStop = false));
                        
                    }
                }
            }
        }


        //movie_idの取得
        private double movie_id()
        {
            string latest_movie = req("https://frontendapi.twitcasting.tv/users/" + User_id() + "/latest-movie");
            var latest_json = DynamicJson.Parse(latest_movie);
            return latest_json.movie.id;
        }
        
        //ws_urlの取得(使いまわし)
        private async Task<string> ws_url()
        {
            var bo = new Dictionary<string, string>()
            {
                {"movie_id", movie_id().ToString() }
            };
            var bo2 = new FormUrlEncodedContent(bo);
            var hc = new HttpClient();
            var tokenjs = await hc.PostAsync("https://twitcasting.tv/eventpubsuburl.php", bo2);
            var token = DynamicJson.Parse(await tokenjs.Content.ReadAsStringAsync()).url;
            return token;
        }

        //シンのradioが押された場合
        private void radio_new_CheckedChanged(object sender, EventArgs e)
        {
            //textboxを触れなくする
            userid_box.Enabled = false;
            //textboxにidを入れる
            userid_box.Text = "c:gomikuzunokiwami";
        }

        //サブのridioが押された場合
        private void radio_sub_CheckedChanged(object sender, EventArgs e)
        {
            userid_box.Enabled = false;
            userid_box.Text = "c:yurusunakimono";
        }

        //感謝のradioが押された場合
        private void radio_kansya_CheckedChanged(object sender, EventArgs e)
        {
            userid_box.Enabled = false;
            userid_box.Text = "c:kansyatyan";
        }

        //その他のradioが押された場合
        private void radio_other_CheckedChanged(object sender, EventArgs e)
        {
            userid_box.Enabled = true;
            userid_box.Text = "";
        }

        private void コメントページを開くToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitcasting.tv/" + User_id() + "/comment/" + movie_id().ToString() + "-" + dataGridView1.SelectedRows[0].Cells[1].Value.ToString());
        }

        private void コピーCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
        }

        private void ユーザーページを開くToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitcasting.tv/" + dataGridView1.SelectedRows[0].Cells[2].Value.ToString());
        }

        private void フォント設定ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.Font = Properties.Settings.Default.font;
            if(fontDialog.ShowDialog() != DialogResult.Cancel)
            {
                Properties.Settings.Default.font = fontDialog.Font;
                Properties.Settings.Default.Save();
            }
        }

        //右クリック時にセルを選択する
        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                dataGridView1.ClearSelection();
                dataGridView1.Rows[e.RowIndex].Selected = true;
            }
        }

        //閉じるときにウィンドウのサイズを保存する
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.width = this.Width;
            Properties.Settings.Default.height = this.Height;
            Properties.Settings.Default.Save();
        }

        //スクロールしたときに自動スクロールを止める
        private void dataGridView1_Scroll(object sender, ScrollEventArgs e)
        {
            ScrollStop = true;
        }

        private void 最新までスクロールToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.Rows.Count - 1;
            ScrollStop = false;
        }
    }
}
