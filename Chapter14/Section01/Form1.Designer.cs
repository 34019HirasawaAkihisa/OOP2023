
namespace Section01 {
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
            this.btRunNotepad = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btRunAddWaitNotepad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btRunNotepad
            // 
            this.btRunNotepad.Location = new System.Drawing.Point(33, 12);
            this.btRunNotepad.Name = "btRunNotepad";
            this.btRunNotepad.Size = new System.Drawing.Size(140, 82);
            this.btRunNotepad.TabIndex = 0;
            this.btRunNotepad.Text = "RunNotepad";
            this.btRunNotepad.UseVisualStyleBackColor = true;
            this.btRunNotepad.Click += new System.EventHandler(this.btRunNotepad_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(97, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btRunAddWaitNotepad
            // 
            this.btRunAddWaitNotepad.Location = new System.Drawing.Point(33, 113);
            this.btRunAddWaitNotepad.Name = "btRunAddWaitNotepad";
            this.btRunAddWaitNotepad.Size = new System.Drawing.Size(140, 72);
            this.btRunAddWaitNotepad.TabIndex = 2;
            this.btRunAddWaitNotepad.Text = "RunAddWaitNotepad";
            this.btRunAddWaitNotepad.UseVisualStyleBackColor = true;
            this.btRunAddWaitNotepad.Click += new System.EventHandler(this.btRunAddWaitNotepad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 220);
            this.Controls.Add(this.btRunAddWaitNotepad);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btRunNotepad);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "14章一節";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btRunNotepad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btRunAddWaitNotepad;
    }
}

