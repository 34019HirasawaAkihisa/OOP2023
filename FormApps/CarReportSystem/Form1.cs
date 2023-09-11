using System;
using System.ComponentModel;
using System.Data;
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
        Settings settings = Settings.getInstance();

        int mode = 0;

        public Form1() {
            InitializeComponent();
            //dgvCarReports.DataSource = carReports;
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

            DataRow newRow = infosys202305DataSet.CarReportTable.NewRow();

            newRow[1] = dtpDate.Value;
            newRow[2] = cbAuthor.Text;
            newRow[3] = getMakerGroup();
            newRow[4] = cbCarName.Text;
            newRow[5] = tbReport.Text;
            newRow[6] = ImageToByteArray(pbCarImage.Image);

            infosys202305DataSet.CarReportTable.Rows.Add(newRow);
            this.carReportTableTableAdapter.Update(infosys202305DataSet.CarReportTable);

            //var carReport = new CarReport() {
            //    Date = dtpDate.Value,
            //    Author = cbAuthor.Text,
            //    CarName = cbCarName.Text,
            //    Report = tbReport.Text,
            //    Maker = getMakerGroup(),
            //    CarImage = pbCarImage.Image,
            //};

            //carReports.Add(carReport);

            setCbAuthor(cbAuthor.Text);
            setCbCarName(cbCarName.Text);

            Clear();

            dgvCarReports.CurrentCell = null;
            btModifyReport.Enabled = false; //マスクする
            btDeleteReport.Enabled = false;
            btScaleChange.Enabled = false;
            btImageDelete.Enabled = false;

        }
        private void setCbCarName(string author) {
            if (cbCarName.Items.Contains(author) == false) {
                cbCarName.Items.Add(author);

            }
        }

        private void setCbAuthor(string carname) {
            if (cbAuthor.Items.Contains(carname) == false) {
                cbAuthor.Items.Add(carname);
            }
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
        private void setSelectedMaker(string makerGroup) {
            switch (makerGroup) {
                case "トヨタ":
                    rbToyota.Checked = true;
                    break;
                case "日産":
                    rbNissan.Checked = true;
                    break;
                case "ホンダ":
                    rbHonda.Checked = true;
                    break;
                case "スバル":
                    rbSubaru.Checked = true;
                    break;
                case "スズキ":
                    rbSuzuki.Checked = true;
                    break;
                case "ダイハツ":
                    rbDaihatsu.Checked = true;
                    break;
                case "輸入車":
                    rbImported.Checked = true;
                    break;
                case "その他":
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

            dgvCarReports.Rows.RemoveAt(dgvCarReports.CurrentRow.Index);
            this.carReportTableTableAdapter.Update(infosys202305DataSet.CarReportTable);
            Clear();

            /*DataGridViewSelectedRowCollection src = dgvCarReports.SelectedRows;
            for (int i = src.Count - 1; i >= 0; i--) {
                dgvCarReports.Rows.RemoveAt(src[i].Index);
            }
            if (dgvCarReports.RowCount == 0) {
                btModifyReport.Enabled = false; //マスクする
                btDeleteReport.Enabled = false;
            }

            dgvCarReports.CurrentCell = null;
            btModifyReport.Enabled = false; //マスクする
            btDeleteReport.Enabled = false;*/
        }

        private void Form1_Load(object sender, EventArgs e) {


            tsinfoText.Text = "";  //情報表示テキストを初期化
            tsTimeDisp.Text = DateTime.Now.ToString("HH時mm分ss秒");
            tmTimeUpdate.Start();

            dgvCarReports.RowsDefaultCellStyle.BackColor = Color.FloralWhite; //全体に色を設定
            dgvCarReports.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke; //奇数行の色を上書き設定

            dgvCarReports.Columns[6].Visible = false; //画像項目非表示
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

            if (dgvCarReports.RowCount != 0) {
                dgvCarReports.CurrentRow.Cells[1].Value = dtpDate.Value;
                dgvCarReports.CurrentRow.Cells[2].Value = cbAuthor.Text;
                dgvCarReports.CurrentRow.Cells[3].Value = getMakerGroup();
                dgvCarReports.CurrentRow.Cells[4].Value = cbCarName.Text;
                dgvCarReports.CurrentRow.Cells[5].Value = tbReport.Text;
                dgvCarReports.CurrentRow.Cells[6].Value = pbCarImage.Image;

                this.Validate();
                this.carReportTableBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.infosys202305DataSet);

                dgvCarReports.CurrentCell = null;
                btModifyReport.Enabled = false; //マスクする
                btDeleteReport.Enabled = false;
            }
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

                        cbAuthor.Items.Clear();
                        cbCarName.Items.Clear();

                        Clear();

                        foreach (var item in carReports) {
                            setCbAuthor(item.Author);
                            setCbCarName(item.CarName);
                        }
                        dgvCarReports.ClearSelection();
                        dgvCarReports.Columns[5].Visible = false;
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //レコード時の選択
        private void dgvCarReports_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (dgvCarReports.RowCount != 0) {
                dtpDate.Value = (DateTime)dgvCarReports.CurrentRow.Cells[1].Value;
                cbAuthor.Text = dgvCarReports.CurrentRow.Cells[2].Value.ToString();
                setSelectedMaker(dgvCarReports.CurrentRow.Cells[3].Value.ToString());
                cbCarName.Text = dgvCarReports.CurrentRow.Cells[4].Value.ToString();
                tbReport.Text = dgvCarReports.CurrentRow.Cells[5].Value.ToString();

                pbCarImage.Image = !dgvCarReports.CurrentRow.Cells[6].Value.Equals(DBNull.Value)
                                            &&((Byte[])dgvCarReports.CurrentRow.Cells[6].Value).Length != 0 ?
                                   ByteArrayToImage((Byte[])dgvCarReports.CurrentRow.Cells[6].Value) : null;         

                /*if (!dgvCarReports.CurrentRow.Cells[6].Value.Equals(DBNull.Value)) {
                    pbCarImage.Image = ByteArrayToImage((byte[])dgvCarReports.CurrentRow.Cells[6].Value);
                }
                else {
                    pbCarImage.Image = null;
                }*/

                if (dgvCarReports.CurrentRow != null) {
                    btModifyReport.Enabled = true;
                    btDeleteReport.Enabled = true;
                    btScaleChange.Enabled = true;
                    btImageDelete.Enabled = true;
                }
            }
        }

        // バイト配列をImageオブジェクトに変換
        public static Image ByteArrayToImage(byte[] b) {
            ImageConverter imgconv = new ImageConverter();
            Image img = (Image)imgconv.ConvertFrom(b);
            return img;
        }

        // Imageオブジェクトをバイト配列に変換
        public static byte[] ImageToByteArray(Image img) {
            ImageConverter imgconv = new ImageConverter();
            byte[] b = (byte[])imgconv.ConvertTo(img, typeof(byte[]));
            return b;
        }

        private void carReportTableBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.carReportTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202305DataSet);

        }

        //接続ボタンのイベントハンドラ
        private void btConnection_Click(object sender, EventArgs e) {
            // TODO: このコード行はデータを 'infosys202305DataSet.CarReportTable' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.carReportTableTableAdapter.Fill(this.infosys202305DataSet.CarReportTable);
            dgvCarReports.ClearSelection(); //選択解除

            foreach (var carReport in infosys202305DataSet.CarReportTable) {
                setCbAuthor(carReport.Author);
                setCbCarName(carReport.CarName);
            }
        }
    }
}

