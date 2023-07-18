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

        ColorDialog cd = new ColorDialog();


        public Form1() {
            InitializeComponent();
            dgvCarReports.DataSource = carReports;
        }
        
        //ステータスラベルのテキスト表示・非表示(引数なしはメッセージ非表示)
        private void statasLabelDisp(string msg = "") {
            tsInfoText.Text = msg;
        }

        //追加ボタンがクリックされた時のイベントハンドラー
        private void btAddReport_Click(object sender, EventArgs e) {
            statasLabelDisp(); //ステータスラベルのテキスト非表示
            if (cbAuthor.Text.Equals("")) {
                tsInfoText.Text = "記録者を入力してください";
                return;
            }
            else if (cbCarName.Text.Equals("")) {
                tsInfoText.Text = "車名を入力してください";
            }
    
            var carReport = new CarReport() {
                Date = dtpDate.Value,
                Author = cbAuthor.Text,
                CarName = cbCarName.Text,
                Report = tbReport.Text,
                Maker = getMakerGroup(),
                CarImage = pbCarImage.Image,
            };

            carReports.Add(carReport);


            if(cbAuthor.Items.Contains(cbAuthor.Text) == false) {
                cbAuthor.Items.Add(cbAuthor.Text);
            }
            if (cbCarName.Items.Contains(cbCarName.Text) == false) {
                cbCarName.Items.Add(cbCarName.Text);
            }

            Clear();

            dgvCarReports.CurrentCell = null;
            btModifyReport.Enabled = false; //マスクする
            btDeleteReport.Enabled = false;

        }

        //ラジオボタンで選択されているメーカーを返却
        private CarReport.MakerGroup getMakerGroup() {
            foreach (var item in gbMaker.Controls) {
                if (((RadioButton)item).Checked) {
                    return (CarReport.MakerGroup)int.Parse(((RadioButton)item).Tag.ToString());
                }
            }
            return CarReport.MakerGroup.その他;
        }

        //指定したメーカーのラジオボタンをセット
        private void setSelectedMaker(CarReport.MakerGroup makerGroup) {
            switch (makerGroup) {
                case CarReport.MakerGroup.トヨタ:
                    rbToyota.Checked = true;
                    break;
                case CarReport.MakerGroup.日産:
                    rbNissan.Checked = true;
                    break;
                case CarReport.MakerGroup.ホンダ:
                    rbHonda.Checked = true;
                    break;
                case CarReport.MakerGroup.スバル:
                    rbSubaru.Checked = true;
                    break;
                case CarReport.MakerGroup.スズキ:
                    rbSuzuki.Checked = true;
                    break;
                case CarReport.MakerGroup.ダイハツ:
                    rbDaihatsu.Checked = true;
                    break;
                case CarReport.MakerGroup.輸入車:
                    rbImported.Checked = true;
                    break;
                case CarReport.MakerGroup.その他:
                    rbOther.Checked = true;
                    break;
                default:
                    break;
            }
        }

        private void btImageOpen_Click(object sender, EventArgs e) {
            ofdImageFileOpen.ShowDialog();
            pbCarImage.Image = Image.FromFile(ofdImageFileOpen.FileName);
        }

        //削除ボタンのイベントハンドラ
        private void btDeleteReport_Click(object sender, EventArgs e) {
            DataGridViewSelectedRowCollection src = dgvCarReports.SelectedRows;
            for (int i = src.Count - 1; i >= 0; i--) {
                dgvCarReports.Rows.RemoveAt(src[i].Index);
            }
            if(dgvCarReports.RowCount == 0) {
                btModifyReport.Enabled = false; //マスクする
                btDeleteReport.Enabled = false;
            }

            dgvCarReports.CurrentCell = null;
            btModifyReport.Enabled = false; //マスクする
            btDeleteReport.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e) {
            dgvCarReports.Columns[5].Visible = false; //画像項目非表示
                btModifyReport.Enabled = false; //マスクする
                btDeleteReport.Enabled = false;
        }

  

        //修正ボタンのイベントハンドラ
        private void btModifyReport_Click(object sender, EventArgs e) {
            dgvCarReports.CurrentRow.Cells[0].Value = dtpDate.Value;
            dgvCarReports.CurrentRow.Cells[1].Value = cbAuthor.Text;
            dgvCarReports.CurrentRow.Cells[2].Value = getMakerGroup();
            dgvCarReports.CurrentRow.Cells[3].Value = cbCarName.Text;
            dgvCarReports.CurrentRow.Cells[4].Value = tbReport.Text;
            dgvCarReports.CurrentRow.Cells[5].Value = pbCarImage.Image;

            dgvCarReports.CurrentCell = null;
            btModifyReport.Enabled = false; //マスクする
            btDeleteReport.Enabled = false;
        }


        private void Clear(string text = "") {
            cbAuthor.Text = text;
            cbCarName.Text = text;
            tbReport.Text = text;
            pbCarImage.Image = null;
            foreach (var item in gbMaker.Controls) {
                ((RadioButton)item).Checked = false;
            }
        }

        private void 終了XToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void バージョン情報ToolStripMenuItem_Click(object sender, EventArgs e) {
            var vf = new VersionForm();
          vf.ShowDialog();  //モーダルダイヤログとして表示
        }

        private void btImageDelete_Click(object sender, EventArgs e) {
            pbCarImage.Image = null;
        }

        //レコードの選択時
        private void dgvCarReports_Click(object sender, EventArgs e) {
            dtpDate.Text = dgvCarReports.CurrentRow.Cells[0].Value.ToString();
            cbAuthor.Text = dgvCarReports.CurrentRow.Cells[1].Value.ToString();
            setSelectedMaker((CarReport.MakerGroup)dgvCarReports.CurrentRow.Cells[2].Value);
            cbCarName.Text = dgvCarReports.CurrentRow.Cells[3].Value.ToString();
            tbReport.Text = dgvCarReports.CurrentRow.Cells[4].Value.ToString();
            pbCarImage.Image = (Image)dgvCarReports.CurrentRow.Cells[5].Value;

            if (dgvCarReports.CurrentRow != null) {
                btModifyReport.Enabled = true;
                btDeleteReport.Enabled = true;
            }
        }

        private void 開くOToolStripMenuItem_Click(object sender, EventArgs e) {

        }


        private void 色設定ToolStripMenuItem_Click(object sender, EventArgs e) {
            cd.ShowDialog();
            this.BackColor = cd.Color;
        }
    }
}
