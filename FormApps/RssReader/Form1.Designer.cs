
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
            this.btDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btGet
            // 
            this.btGet.Location = new System.Drawing.Point(1139, 12);
            this.btGet.Name = "btGet";
            this.btGet.Size = new System.Drawing.Size(40, 30);
            this.btGet.TabIndex = 0;
            this.btGet.Text = "取得";
            this.btGet.UseVisualStyleBackColor = true;
            this.btGet.Click += new System.EventHandler(this.btGet_Click);
            // 
            // tbUrl
            // 
            this.tbUrl.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbUrl.Location = new System.Drawing.Point(90, 13);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(1043, 26);
            this.tbUrl.TabIndex = 1;
            // 
            // lbRssTitle
            // 
            this.lbRssTitle.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbRssTitle.FormattingEnabled = true;
            this.lbRssTitle.ItemHeight = 19;
            this.lbRssTitle.Location = new System.Drawing.Point(167, 41);
            this.lbRssTitle.Name = "lbRssTitle";
            this.lbRssTitle.Size = new System.Drawing.Size(966, 99);
            this.lbRssTitle.TabIndex = 2;
            this.lbRssTitle.Click += new System.EventHandler(this.lbRssTitle_Click);
            // 
            // wbBrowser
            // 
            this.wbBrowser.Location = new System.Drawing.Point(29, 146);
            this.wbBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbBrowser.Name = "wbBrowser";
            this.wbBrowser.ScriptErrorsSuppressed = true;
            this.wbBrowser.Size = new System.Drawing.Size(1185, 651);
            this.wbBrowser.TabIndex = 3;
            // 
            // bk
            // 
            this.bk.Location = new System.Drawing.Point(29, 13);
            this.bk.Name = "bk";
            this.bk.Size = new System.Drawing.Size(33, 27);
            this.bk.TabIndex = 4;
            this.bk.Text = "←";
            this.bk.UseVisualStyleBackColor = true;
            this.bk.Click += new System.EventHandler(this.bk_Click);
            // 
            // gf
            // 
            this.gf.Location = new System.Drawing.Point(59, 13);
            this.gf.Name = "gf";
            this.gf.Size = new System.Drawing.Size(34, 27);
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
            this.dTitle.Location = new System.Drawing.Point(1140, 61);
            this.dTitle.Name = "dTitle";
            this.dTitle.Size = new System.Drawing.Size(75, 23);
            this.dTitle.TabIndex = 7;
            this.dTitle.Text = "下の記事へ";
            this.dTitle.UseVisualStyleBackColor = true;
            this.dTitle.Click += new System.EventHandler(this.dTitle_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(1176, 12);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(39, 30);
            this.btDelete.TabIndex = 8;
            this.btDelete.Text = "削除";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 838);
            this.Controls.Add(this.btDelete);
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
        private System.Windows.Forms.Button btDelete;
    }
}

