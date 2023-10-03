
namespace RssReader {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.btGet = new System.Windows.Forms.Button();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.lbRssTitle = new System.Windows.Forms.ListBox();
            this.wbBrowser = new System.Windows.Forms.WebBrowser();
            this.bk = new System.Windows.Forms.Button();
            this.gf = new System.Windows.Forms.Button();
            this.uTitle = new System.Windows.Forms.Button();
            this.dTitle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btGet
            // 
            this.btGet.Location = new System.Drawing.Point(1139, 12);
            this.btGet.Name = "btGet";
            this.btGet.Size = new System.Drawing.Size(75, 23);
            this.btGet.TabIndex = 0;
            this.btGet.Text = "取得";
            this.btGet.UseVisualStyleBackColor = true;
            this.btGet.Click += new System.EventHandler(this.btGet_Click);
            // 
            // tbUrl
            // 
            this.tbUrl.Location = new System.Drawing.Point(90, 13);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(1043, 19);
            this.tbUrl.TabIndex = 1;
            // 
            // lbRssTitle
            // 
            this.lbRssTitle.FormattingEnabled = true;
            this.lbRssTitle.ItemHeight = 12;
            this.lbRssTitle.Location = new System.Drawing.Point(29, 41);
            this.lbRssTitle.Name = "lbRssTitle";
            this.lbRssTitle.Size = new System.Drawing.Size(1104, 100);
            this.lbRssTitle.TabIndex = 2;
            this.lbRssTitle.Click += new System.EventHandler(this.lbRssTitle_Click);
            // 
            // wbBrowser
            // 
            this.wbBrowser.Location = new System.Drawing.Point(29, 146);
            this.wbBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbBrowser.Name = "wbBrowser";
            this.wbBrowser.ScriptErrorsSuppressed = true;
            this.wbBrowser.Size = new System.Drawing.Size(1185, 680);
            this.wbBrowser.TabIndex = 3;
            // 
            // bk
            // 
            this.bk.Location = new System.Drawing.Point(29, 9);
            this.bk.Name = "bk";
            this.bk.Size = new System.Drawing.Size(24, 24);
            this.bk.TabIndex = 4;
            this.bk.Text = "←";
            this.bk.UseVisualStyleBackColor = true;
            this.bk.Click += new System.EventHandler(this.bk_Click);
            // 
            // gf
            // 
            this.gf.Location = new System.Drawing.Point(59, 10);
            this.gf.Name = "gf";
            this.gf.Size = new System.Drawing.Size(25, 23);
            this.gf.TabIndex = 5;
            this.gf.Text = "→";
            this.gf.UseVisualStyleBackColor = true;
            this.gf.Click += new System.EventHandler(this.gf_Click);
            // 
            // uTitle
            // 
            this.uTitle.Location = new System.Drawing.Point(1140, 41);
            this.uTitle.Name = "uTitle";
            this.uTitle.Size = new System.Drawing.Size(75, 23);
            this.uTitle.TabIndex = 6;
            this.uTitle.Text = "上の記事へ";
            this.uTitle.UseVisualStyleBackColor = true;
            this.uTitle.Click += new System.EventHandler(this.uTitle_Click);
            // 
            // dTitle
            // 
            this.dTitle.Location = new System.Drawing.Point(1140, 70);
            this.dTitle.Name = "dTitle";
            this.dTitle.Size = new System.Drawing.Size(75, 23);
            this.dTitle.TabIndex = 7;
            this.dTitle.Text = "下の記事へ";
            this.dTitle.UseVisualStyleBackColor = true;
            this.dTitle.Click += new System.EventHandler(this.dTitle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 838);
            this.Controls.Add(this.dTitle);
            this.Controls.Add(this.uTitle);
            this.Controls.Add(this.gf);
            this.Controls.Add(this.bk);
            this.Controls.Add(this.wbBrowser);
            this.Controls.Add(this.lbRssTitle);
            this.Controls.Add(this.tbUrl);
            this.Controls.Add(this.btGet);
            this.Name = "Form1";
            this.Text = "z";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btGet;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.ListBox lbRssTitle;
        private System.Windows.Forms.WebBrowser wbBrowser;
        private System.Windows.Forms.Button bk;
        private System.Windows.Forms.Button gf;
        private System.Windows.Forms.Button uTitle;
        private System.Windows.Forms.Button dTitle;
    }
}

