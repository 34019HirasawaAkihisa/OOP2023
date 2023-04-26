using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallApp {
    class Program : Form {

        Bar bar;            //Baeインスタンス格納
        PictureBox pbBar;   //Bar表示用

        private Timer moveTimer;  //タイマー用

        private PictureBox pb;
        private Obj obj;

        private List<Obj> ball = new List<Obj>(); //ボールインスタンス格納用 
        private List<PictureBox> pbs = new List<PictureBox>(); //表示用

        static void Main(string[] args) {
            Application.Run(new Program());
        }

        public Program() {

            //フォーム
            this.Size = new Size(800, 600);
            this.BackColor = Color.Green;
            this.Text = "BallGame";
            this.MouseClick += Program_MouseClick;
            this.KeyDown += Program_KeyDown;

            moveTimer = new Timer();
            moveTimer.Interval = 10; //タイマーのインターバル(ms)
            moveTimer.Tick += MoveTimer_Tick;  //デリゲート登録

            //Barインスタンス生成
            bar = new Bar(300, 500);
            pbBar = new PictureBox();
            pbBar.Image = bar.Image;
            pbBar.Location = new Point((int)bar.PosX, (int)bar.PosY);
            pbBar.Size = new Size(150, 10);
            pbBar.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBar.Parent = this;
        }

        //キーが押された時のイベントハンドラ
        private void Program_KeyDown(object sender, KeyEventArgs e) {
            bar.Move(e.KeyData);
            pbBar.Location = new Point((int)bar.PosX, (int)bar.PosY);
        }
        //マウスクリック時のイベントハンドラ
        private void Program_MouseClick(object sender, MouseEventArgs e) {
            pb = new PictureBox(); //画像を表示するコントロール
            if (e.Button == MouseButtons.Left)
            {
                //ボールインスタンス作成
                obj = new SoccerBall(e.X - 25, e.Y - 25);
                pb.Size = new Size(50, 50); //画像の表示サイズ
            }
            else if (e.Button == MouseButtons.Right)
            {
                obj = new TennisBall(e.X - 25, e.Y - 25);
                pb.Size = new Size(25, 25); //画像の表示サイズ
            }

            pb.Image = obj.Image;
            pb.Location = new Point((int)obj.PosX, (int)obj.PosY); //画像の位置
            pb.SizeMode = PictureBoxSizeMode.StretchImage; //画像の表示モード
            pb.Parent = this;
            ball.Add(obj);
            pbs.Add(pb);

            this.Text = "サッカーボール:" + SoccerBall.Cnt + "テニスボール:" + TennisBall.Cnt;

            moveTimer.Start(); //タイマースタート
        }

        //タイマーアウト時のイベントハンドラ
        private void MoveTimer_Tick(object sender, EventArgs e) {
            for (int i = 0; i < ball.Count; i++)
            {
                ball[i].Move();  //移動
                pbs[i].Location = new Point((int)ball[i].PosX, (int)ball[i].PosY);
            }
        }
    }
}