﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btButton_Click(object sender, EventArgs e) {
            //int Ans = int.Parse(tbNum1.Text) + int.Parse(tbNum2.Text);
            int num1 = int.Parse(tbNum1.Text);
            int num2 = int.Parse(tbNum2.Text);
            int sum = num1 + num2;
            tbAns.Text = sum.ToString();

            
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e) {

        }

        private void label3_Click(object sender, EventArgs e) {
            
        }
        //イベントハンドラ
        private void btPow_Click(object sender, EventArgs e) {
           double ans = System.Math.Pow((double)nudX.Value,(double)nudY.Value);
            tbResult.Text = ans.ToString();

            //一行
            //tbResult.Text = (Math.Pow((double)nudX.Value,(double)nudY.Value)).Tostring();
        }
    }
}
 