using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallApp {
    class Program : Form {

        private Timer moveTimer;  //タイマー用
        private PictureBox pb;
        private Obj obj;
        private List<Obj> ball = new List<Obj>(); //ボールインスタンス格納用 
        private List<PictureBox> pbs = new List<PictureBox>(); //表示用

        private int BallCount = 0;

        static void Main(string[] args) {
            Application.Run(new Program());
        }

        public Program() {

            this.Size = new Size(800, 600);
            this.BackColor = Color.Green;
            this.Text = "BallGame";
            this.MouseClick += Program_MouseClick;

            moveTimer = new Timer();
            moveTimer.Interval = 10; //タイマーのインターバル(ms)

            moveTimer.Tick += MoveTimer_Tick;  //デリゲート登録

        }

        //マウスクリック時のイベントハンドラ
        private void Program_MouseClick(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left)
            {
                //ボールインスタンス作成
                this.Text = "Ballgame" + "(" + ++BallCount + ")";
                obj = new SoccerBall(e.X - 25, e.Y - 25);
            }
            if (e.Button == MouseButtons.Right)
            {
                this.Text = "Ballgame" + "(" + ++BallCount + ")";
                obj = new TennisBall(e.X - 25, e.Y - 25);
            }
            pb = new PictureBox(); //画像を表示するコントロール
            pb.Image = obj.Image;
            pb.Location = new Point((int)obj.PosX, (int)obj.PosY); //画像の位置
            pb.Size = new Size(50, 50); //画像の表示サイズ
            pb.SizeMode = PictureBoxSizeMode.StretchImage; //画像の表示モード
            pb.Parent = this;
            ball.Add(obj);
            pbs.Add(pb);

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