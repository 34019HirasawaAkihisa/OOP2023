
namespace CalendarApp {
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btDayCalc = new System.Windows.Forms.Button();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.beforeYearbt = new System.Windows.Forms.Button();
            this.afterYearbt = new System.Windows.Forms.Button();
            this.beforeMonthbt = new System.Windows.Forms.Button();
            this.afterMonthbt = new System.Windows.Forms.Button();
            this.beforeDaybt = new System.Windows.Forms.Button();
            this.afterDaybt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "日付：";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(95, 19);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(240, 36);
            this.dtpDate.TabIndex = 1;
            // 
            // btDayCalc
            // 
            this.btDayCalc.Location = new System.Drawing.Point(64, 71);
            this.btDayCalc.Name = "btDayCalc";
            this.btDayCalc.Size = new System.Drawing.Size(271, 44);
            this.btDayCalc.TabIndex = 2;
            this.btDayCalc.Text = "日数計算";
            this.btDayCalc.UseVisualStyleBackColor = true;
            this.btDayCalc.Click += new System.EventHandler(this.btDayCalc_Click);
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(361, 16);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(327, 230);
            this.tbMessage.TabIndex = 3;
            // 
            // beforeYearbt
            // 
            this.beforeYearbt.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.beforeYearbt.Location = new System.Drawing.Point(64, 121);
            this.beforeYearbt.Name = "beforeYearbt";
            this.beforeYearbt.Size = new System.Drawing.Size(135, 40);
            this.beforeYearbt.TabIndex = 4;
            this.beforeYearbt.Text = "ー年";
            this.beforeYearbt.UseVisualStyleBackColor = true;
            // 
            // afterYearbt
            // 
            this.afterYearbt.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.afterYearbt.Location = new System.Drawing.Point(205, 121);
            this.afterYearbt.Name = "afterYearbt";
            this.afterYearbt.Size = new System.Drawing.Size(130, 40);
            this.afterYearbt.TabIndex = 5;
            this.afterYearbt.Text = "＋年";
            this.afterYearbt.UseVisualStyleBackColor = true;
            // 
            // beforeMonthbt
            // 
            this.beforeMonthbt.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.beforeMonthbt.Location = new System.Drawing.Point(64, 167);
            this.beforeMonthbt.Name = "beforeMonthbt";
            this.beforeMonthbt.Size = new System.Drawing.Size(135, 37);
            this.beforeMonthbt.TabIndex = 6;
            this.beforeMonthbt.Text = "ー月";
            this.beforeMonthbt.UseVisualStyleBackColor = true;
            // 
            // afterMonthbt
            // 
            this.afterMonthbt.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.afterMonthbt.Location = new System.Drawing.Point(205, 167);
            this.afterMonthbt.Name = "afterMonthbt";
            this.afterMonthbt.Size = new System.Drawing.Size(130, 38);
            this.afterMonthbt.TabIndex = 7;
            this.afterMonthbt.Text = "＋月";
            this.afterMonthbt.UseVisualStyleBackColor = true;
            // 
            // beforeDaybt
            // 
            this.beforeDaybt.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.beforeDaybt.Location = new System.Drawing.Point(64, 211);
            this.beforeDaybt.Name = "beforeDaybt";
            this.beforeDaybt.Size = new System.Drawing.Size(135, 35);
            this.beforeDaybt.TabIndex = 8;
            this.beforeDaybt.Text = "ー日";
            this.beforeDaybt.UseVisualStyleBackColor = true;
            // 
            // afterDaybt
            // 
            this.afterDaybt.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.afterDaybt.Location = new System.Drawing.Point(205, 211);
            this.afterDaybt.Name = "afterDaybt";
            this.afterDaybt.Size = new System.Drawing.Size(130, 35);
            this.afterDaybt.TabIndex = 9;
            this.afterDaybt.Text = "＋日";
            this.afterDaybt.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 267);
            this.Controls.Add(this.afterDaybt);
            this.Controls.Add(this.beforeDaybt);
            this.Controls.Add(this.afterMonthbt);
            this.Controls.Add(this.beforeMonthbt);
            this.Controls.Add(this.afterYearbt);
            this.Controls.Add(this.beforeYearbt);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.btDayCalc);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form1";
            this.Text = "カレンダーアプリ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btDayCalc;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.Button beforeYearbt;
        private System.Windows.Forms.Button afterYearbt;
        private System.Windows.Forms.Button beforeMonthbt;
        private System.Windows.Forms.Button afterMonthbt;
        private System.Windows.Forms.Button beforeDaybt;
        private System.Windows.Forms.Button afterDaybt;
    }
}

