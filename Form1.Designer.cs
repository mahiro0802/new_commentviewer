
namespace シンコメビュ
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.終了ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.フォント設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.最新までスクロールToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userid_box = new System.Windows.Forms.TextBox();
            this.connect_button = new System.Windows.Forms.Button();
            this.radio_new = new System.Windows.Forms.RadioButton();
            this.radio_sub = new System.Windows.Forms.RadioButton();
            this.radio_kansya = new System.Windows.Forms.RadioButton();
            this.radio_other = new System.Windows.Forms.RadioButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.コピーCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ユーザーページを開くToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.コメントページを開くToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(12, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(580, 505);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDown);
            this.dataGridView1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dataGridView1_Scroll);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "コメント";
            this.Column1.Name = "Column1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルFToolStripMenuItem,
            this.設定ToolStripMenuItem,
            this.最新までスクロールToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(604, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ファイルFToolStripMenuItem
            // 
            this.ファイルFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.終了ToolStripMenuItem});
            this.ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem";
            this.ファイルFToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.ファイルFToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(95, 6);
            // 
            // 終了ToolStripMenuItem
            // 
            this.終了ToolStripMenuItem.Name = "終了ToolStripMenuItem";
            this.終了ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.終了ToolStripMenuItem.Text = "終了";
            // 
            // 設定ToolStripMenuItem
            // 
            this.設定ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.フォント設定ToolStripMenuItem});
            this.設定ToolStripMenuItem.Name = "設定ToolStripMenuItem";
            this.設定ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.設定ToolStripMenuItem.Text = "設定";
            // 
            // フォント設定ToolStripMenuItem
            // 
            this.フォント設定ToolStripMenuItem.Name = "フォント設定ToolStripMenuItem";
            this.フォント設定ToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.フォント設定ToolStripMenuItem.Text = "フォント設定";
            this.フォント設定ToolStripMenuItem.Click += new System.EventHandler(this.フォント設定ToolStripMenuItem_Click);
            // 
            // 最新までスクロールToolStripMenuItem
            // 
            this.最新までスクロールToolStripMenuItem.Name = "最新までスクロールToolStripMenuItem";
            this.最新までスクロールToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.最新までスクロールToolStripMenuItem.Text = "最新までスクロール";
            this.最新までスクロールToolStripMenuItem.Click += new System.EventHandler(this.最新までスクロールToolStripMenuItem_Click);
            // 
            // userid_box
            // 
            this.userid_box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userid_box.Enabled = false;
            this.userid_box.Location = new System.Drawing.Point(12, 27);
            this.userid_box.Name = "userid_box";
            this.userid_box.Size = new System.Drawing.Size(499, 19);
            this.userid_box.TabIndex = 2;
            this.userid_box.Text = "c:gomikuzunokiwami";
            // 
            // connect_button
            // 
            this.connect_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.connect_button.Location = new System.Drawing.Point(517, 25);
            this.connect_button.Name = "connect_button";
            this.connect_button.Size = new System.Drawing.Size(75, 23);
            this.connect_button.TabIndex = 3;
            this.connect_button.Text = "接続";
            this.connect_button.UseVisualStyleBackColor = true;
            this.connect_button.Click += new System.EventHandler(this.connect_button_Click);
            // 
            // radio_new
            // 
            this.radio_new.AutoSize = true;
            this.radio_new.Checked = true;
            this.radio_new.Location = new System.Drawing.Point(12, 52);
            this.radio_new.Name = "radio_new";
            this.radio_new.Size = new System.Drawing.Size(42, 16);
            this.radio_new.TabIndex = 4;
            this.radio_new.TabStop = true;
            this.radio_new.Text = "シン";
            this.radio_new.UseVisualStyleBackColor = true;
            this.radio_new.CheckedChanged += new System.EventHandler(this.radio_new_CheckedChanged);
            // 
            // radio_sub
            // 
            this.radio_sub.AutoSize = true;
            this.radio_sub.Location = new System.Drawing.Point(60, 52);
            this.radio_sub.Name = "radio_sub";
            this.radio_sub.Size = new System.Drawing.Size(42, 16);
            this.radio_sub.TabIndex = 5;
            this.radio_sub.TabStop = true;
            this.radio_sub.Text = "サブ";
            this.radio_sub.UseVisualStyleBackColor = true;
            this.radio_sub.CheckedChanged += new System.EventHandler(this.radio_sub_CheckedChanged);
            // 
            // radio_kansya
            // 
            this.radio_kansya.AutoSize = true;
            this.radio_kansya.Location = new System.Drawing.Point(108, 52);
            this.radio_kansya.Name = "radio_kansya";
            this.radio_kansya.Size = new System.Drawing.Size(47, 16);
            this.radio_kansya.TabIndex = 6;
            this.radio_kansya.TabStop = true;
            this.radio_kansya.Text = "感謝";
            this.radio_kansya.UseVisualStyleBackColor = true;
            this.radio_kansya.CheckedChanged += new System.EventHandler(this.radio_kansya_CheckedChanged);
            // 
            // radio_other
            // 
            this.radio_other.AutoSize = true;
            this.radio_other.Location = new System.Drawing.Point(161, 52);
            this.radio_other.Name = "radio_other";
            this.radio_other.Size = new System.Drawing.Size(54, 16);
            this.radio_other.TabIndex = 7;
            this.radio_other.TabStop = true;
            this.radio_other.Text = "その他";
            this.radio_other.UseVisualStyleBackColor = true;
            this.radio_other.CheckedChanged += new System.EventHandler(this.radio_other_CheckedChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.コピーCToolStripMenuItem,
            this.ユーザーページを開くToolStripMenuItem,
            this.コメントページを開くToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(167, 70);
            // 
            // コピーCToolStripMenuItem
            // 
            this.コピーCToolStripMenuItem.Name = "コピーCToolStripMenuItem";
            this.コピーCToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.コピーCToolStripMenuItem.Text = "コピー(&C)";
            this.コピーCToolStripMenuItem.Click += new System.EventHandler(this.コピーCToolStripMenuItem_Click);
            // 
            // ユーザーページを開くToolStripMenuItem
            // 
            this.ユーザーページを開くToolStripMenuItem.Name = "ユーザーページを開くToolStripMenuItem";
            this.ユーザーページを開くToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.ユーザーページを開くToolStripMenuItem.Text = "ユーザーページを開く";
            this.ユーザーページを開くToolStripMenuItem.Click += new System.EventHandler(this.ユーザーページを開くToolStripMenuItem_Click);
            // 
            // コメントページを開くToolStripMenuItem
            // 
            this.コメントページを開くToolStripMenuItem.Name = "コメントページを開くToolStripMenuItem";
            this.コメントページを開くToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.コメントページを開くToolStripMenuItem.Text = "コメントページを開く";
            this.コメントページを開くToolStripMenuItem.Click += new System.EventHandler(this.コメントページを開くToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 591);
            this.Controls.Add(this.radio_other);
            this.Controls.Add(this.radio_kansya);
            this.Controls.Add(this.radio_sub);
            this.Controls.Add(this.radio_new);
            this.Controls.Add(this.connect_button);
            this.Controls.Add(this.userid_box);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "シンコメビュ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ファイルFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 設定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem フォント設定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 終了ToolStripMenuItem;
        private System.Windows.Forms.TextBox userid_box;
        private System.Windows.Forms.Button connect_button;
        private System.Windows.Forms.RadioButton radio_new;
        private System.Windows.Forms.RadioButton radio_sub;
        private System.Windows.Forms.RadioButton radio_kansya;
        private System.Windows.Forms.RadioButton radio_other;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem コピーCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ユーザーページを開くToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem コメントページを開くToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 最新までスクロールToolStripMenuItem;
    }
}

