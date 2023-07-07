using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem {
    public partial class Form1 : Form {
        //管理用データ
        BindingList<CarReport> carReports = new BindingList<CarReport>();

        public Form1() {
            InitializeComponent();
            dgvCarReports.DataSource = carReports;
        }

        //追加ボタンがクリックされた時のイベントハンドラー
        private void btAddReport_Click(object sender, EventArgs e) {
            var carReport = new CarReport();
            carReport.Date = dtpDate.Value;
            carReport.Author = cbAuthor.Text;
            carReport.Maker = getMakerGroup();
            carReport.CarName = cbCarName.Text;
            carReport.Report = tbReport.Text;

            carReports.Add(carReport);
            dgvCarReports.DataSource = carReports;
        }

        private CarReport.MakerGroup getMakerGroup() {

            return CarReport.MakerGroup.その他;

        }

        private void gbMaker_Enter(object sender, EventArgs e) {

        }
    }
}
