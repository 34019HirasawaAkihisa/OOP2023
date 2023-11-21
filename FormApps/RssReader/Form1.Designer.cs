
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
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.rb4 = new System.Windows.Forms.RadioButton();
            this.tburlName = new System.Windows.Forms.TextBox();
            this.tbfavoriteName = new System.Windows.Forms.TextBox();
            this.cbfavorite = new System.Windows.Forms.ComboBox();
            this.btfavorite = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorlb = new System.Windows.Forms.Label();
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
            this.lbRssTitle.Location = new System.Drawing.Point(29, 41);
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
            this.wbBrowser.Size = new System.Drawing.Size(1033, 651);
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
            this.uTitle.Location = new System.Drawing.Point(1058, 41);
            this.uTitle.Name = "uTitle";
            this.uTitle.Size = new System.Drawing.Size(75, 23);
            this.uTitle.TabIndex = 6;
            this.uTitle.Text = "上の記事へ";
            this.uTitle.UseVisualStyleBackColor = true;
            this.uTitle.Click += new System.EventHandler(this.uTitle_Click);
            // 
            // dTitle
            // 
            this.dTitle.Location = new System.Drawing.Point(1139, 42);
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
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Location = new System.Drawing.Point(1001, 49);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(47, 16);
            this.rb1.TabIndex = 9;
            this.rb1.TabStop = true;
            this.rb1.Text = "経済";
            this.rb1.UseVisualStyleBackColor = true;
            this.rb1.CheckedChanged += new System.EventHandler(this.rb1_CheckedChanged);
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(1001, 71);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(57, 16);
            this.rb2.TabIndex = 9;
            this.rb2.TabStop = true;
            this.rb2.Text = "エンタメ";
            this.rb2.UseVisualStyleBackColor = true;
            this.rb2.CheckedChanged += new System.EventHandler(this.rb2_CheckedChanged);
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.Location = new System.Drawing.Point(1001, 93);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(61, 16);
            this.rb3.TabIndex = 9;
            this.rb3.TabStop = true;
            this.rb3.Text = "スポーツ";
            this.rb3.UseVisualStyleBackColor = true;
            this.rb3.CheckedChanged += new System.EventHandler(this.rb3_CheckedChanged);
            // 
            // rb4
            // 
            this.rb4.AutoSize = true;
            this.rb4.Location = new System.Drawing.Point(1001, 115);
            this.rb4.Name = "rb4";
            this.rb4.Size = new System.Drawing.Size(33, 16);
            this.rb4.TabIndex = 9;
            this.rb4.TabStop = true;
            this.rb4.Text = "IT";
            this.rb4.UseVisualStyleBackColor = true;
            this.rb4.CheckedChanged += new System.EventHandler(this.rb4_CheckedChanged);
            // 
            // tburlName
            // 
            this.tburlName.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tburlName.Location = new System.Drawing.Point(1079, 146);
            this.tburlName.Name = "tburlName";
            this.tburlName.Size = new System.Drawing.Size(162, 31);
            this.tburlName.TabIndex = 10;
            // 
            // tbfavoriteName
            // 
            this.tbfavoriteName.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbfavoriteName.Location = new System.Drawing.Point(1079, 195);
            this.tbfavoriteName.Name = "tbfavoriteName";
            this.tbfavoriteName.Size = new System.Drawing.Size(162, 31);
            this.tbfavoriteName.TabIndex = 11;
            // 
            // cbfavorite
            // 
            this.cbfavorite.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cbfavorite.FormattingEnabled = true;
            this.cbfavorite.Location = new System.Drawing.Point(1077, 278);
            this.cbfavorite.Name = "cbfavorite";
            this.cbfavorite.Size = new System.Drawing.Size(162, 32);
            this.cbfavorite.TabIndex = 12;
            this.cbfavorite.SelectedIndexChanged += new System.EventHandler(this.cbfavorite_SelectedIndexChanged);
            // 
            // btfavorite
            // 
            this.btfavorite.Location = new System.Drawing.Point(1151, 249);
            this.btfavorite.Name = "btfavorite";
            this.btfavorite.Size = new System.Drawing.Size(90, 23);
            this.btfavorite.TabIndex = 13;
            this.btfavorite.Text = "お気に入り登録";
            this.btfavorite.UseVisualStyleBackColor = true;
            this.btfavorite.Click += new System.EventHandler(this.btfavorite_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1212, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "URL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1210, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "名前";
            // 
            // errorlb
            // 
            this.errorlb.AutoSize = true;
            this.errorlb.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.errorlb.Location = new System.Drawing.Point(1087, 325);
            this.errorlb.Name = "errorlb";
            this.errorlb.Size = new System.Drawing.Size(0, 24);
            this.errorlb.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 838);
            this.Controls.Add(this.errorlb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btfavorite);
            this.Controls.Add(this.cbfavorite);
            this.Controls.Add(this.tbfavoriteName);
            this.Controls.Add(this.tburlName);
            this.Controls.Add(this.rb4);
            this.Controls.Add(this.rb3);
            this.Controls.Add(this.rb2);
            this.Controls.Add(this.rb1);
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
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.RadioButton rb4;
        private System.Windows.Forms.TextBox tburlName;
        private System.Windows.Forms.TextBox tbfavoriteName;
        private System.Windows.Forms.ComboBox cbfavorite;
        private System.Windows.Forms.Button btfavorite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label errorlb;
    }
}

