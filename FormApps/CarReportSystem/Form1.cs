using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace CarReportSystem {
    public partial class Form1 : Form {
        //管理用データ
        BindingList<CarReport> carReports = new BindingList<CarReport>();

        //設定情報保存用オブジェクト
        Settings settings = new Settings();

        int mode = 0;

        public Form1() {
            InitializeComponent();
            dgvCarReports.DataSource = carReports;
        }

        //ステータスラベルのテキスト表示・非表示(引数なしはメッセージ非表示)
        private void statasLabelDisp(string msg = "") {
            tsTimeDisp.Text = msg;
        }

        //追加ボタンがクリックされた時のイベントハンドラー
        private void btAddReport_Click(object sender, EventArgs e) {
            statasLabelDisp(); //ステータスラベルのテキスト非表示
            if (cbAuthor.Text.Equals("")) {
                tsTimeDisp.Text = "記録者を入力してください";
                return;
            }
            else if (cbCarName.Text.Equals("")) {
                tsTimeDisp.Text = "車名を入力してください";
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

            if (cbAuthor.Items.Contains(cbAuthor.Text) == false) {
                cbAuthor.Items.Add(cbAuthor.Text);
            }
            if (cbCarName.Items.Contains(cbCarName.Text) == false) {
                cbCarName.Items.Add(cbCarName.Text);
            }

            Clear();

            dgvCarReports.CurrentCell = null;
            btModifyReport.Enabled = false; //マスクする
            btDeleteReport.Enabled = false;
            btScaleChange.Enabled = false;
            btImageDelete.Enabled = false;

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
            if (ofdImageFileOpen.ShowDialog() == DialogResult.OK) {
                pbCarImage.Image = Image.FromFile(ofdImageFileOpen.FileName);
                btScaleChange.Enabled = true;
                btImageDelete.Enabled = true;
            }
        }

        //削除ボタンのイベントハンドラ
        private void btDeleteReport_Click(object sender, EventArgs e) {
            DataGridViewSelectedRowCollection src = dgvCarReports.SelectedRows;
            for (int i = src.Count - 1; i >= 0; i--) {
                dgvCarReports.Rows.RemoveAt(src[i].Index);
            }
            if (dgvCarReports.RowCount == 0) {
                btModifyReport.Enabled = false; //マスクする
                btDeleteReport.Enabled = false;
            }

            dgvCarReports.CurrentCell = null;
            btModifyReport.Enabled = false; //マスクする
            btDeleteReport.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e) {

            tsinfoText.Text = "";  //情報表示テキストを初期化
            tsTimeDisp.Text = DateTime.Now.ToString("HH時mm分ss秒");
            tmTimeUpdate.Start();

            dgvCarReports.Columns[5].Visible = false; //画像項目非表示
            btModifyReport.Enabled = false; //マスクする
            btDeleteReport.Enabled = false;
            btScaleChange.Enabled = false;
            btImageDelete.Enabled = false;

            try {
                //設定ファイル逆シリアル化して背景に設定
                using (var reader = XmlReader.Create("bColor.xml")) {
                    var serializer = new XmlSerializer(typeof(Settings));
                    settings = serializer.Deserialize(reader) as Settings;
                    BackColor = Color.FromArgb(settings.MainFormColor);
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
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
            btScaleChange.Enabled = false;
            btImageDelete.Enabled = false;
        }

        //レコードの選択時
        private void dgvCarReports_Click(object sender, EventArgs e) {
            if (dgvCarReports.RowCount != 0) {
                dtpDate.Text = dgvCarReports.CurrentRow.Cells[0].Value.ToString();
                cbAuthor.Text = dgvCarReports.CurrentRow.Cells[1].Value.ToString();
                setSelectedMaker((CarReport.MakerGroup)dgvCarReports.CurrentRow.Cells[2].Value);
                cbCarName.Text = dgvCarReports.CurrentRow.Cells[3].Value.ToString();
                tbReport.Text = dgvCarReports.CurrentRow.Cells[4].Value.ToString();
                pbCarImage.Image = (Image)dgvCarReports.CurrentRow.Cells[5].Value;

                if (dgvCarReports.CurrentRow != null) {
                    btModifyReport.Enabled = true;
                    btDeleteReport.Enabled = true;
                    btScaleChange.Enabled = true;
                    btImageDelete.Enabled = true;
                }
            }
        }

        private void 色設定ToolStripMenuItem_Click(object sender, EventArgs e) {
            if (cdColor.ShowDialog() == DialogResult.OK) {
                BackColor = cdColor.Color;
                settings.MainFormColor = cdColor.Color.ToArgb();
            }
        }

        private void btScaleChange_Click(object sender, EventArgs e) {
            mode = mode < 4 ? ((mode == 1) ? 3 : ++mode) : 0;   //AutoSize(2)を除外
            pbCarImage.SizeMode = (PictureBoxSizeMode)mode;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
            //設定ファイルのシリアル化
            using (var writer = XmlWriter.Create("bColor.xml")) {
                var serializer = new XmlSerializer(settings.GetType());
                serializer.Serialize(writer, settings);
            }
        }

        private void tmTimeUpdate_Tick(object sender, EventArgs e) {
            tsTimeDisp.Text = DateTime.Now.ToString("HH時mm分ss秒");
        }

        private void 保存SToolStripMenuItem_Click(object sender, EventArgs e) {
            if (sfdCarRepoSave.ShowDialog() == DialogResult.OK) {
                try {
                    //バイナリ形式でシリアル化
                    var bf = new BinaryFormatter();
                    using (FileStream fs = File.Open(sfdCarRepoSave.FileName, FileMode.Create)) {
                        bf.Serialize(fs, carReports);
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void 開くOToolStripMenuItem_Click(object sender, EventArgs e) {
            if (ofdCarRepoOpen.ShowDialog() == DialogResult.OK) {
                try {
                    //逆シリアル化
                    var bf = new BinaryFormatter();
                    using (FileStream fs = File.Open(ofdCarRepoOpen.FileName, FileMode.Open, FileAccess.Read)) {
                        carReports = (BindingList<CarReport>)bf.Deserialize(fs);
                        dgvCarReports.DataSource = null;
                        dgvCarReports.DataSource = carReports;
                        foreach (var item in carReports) {
                            if (cbAuthor.Items.Contains(item.Author) == false) {
                                cbAuthor.Items.Add(item.Author);
                            }
                            if (cbCarName.Items.Contains(item.CarName) == false) {
                                cbCarName.Items.Add(item.CarName);
                            }
                        }
                        dgvCarReports.ClearSelection();
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}

