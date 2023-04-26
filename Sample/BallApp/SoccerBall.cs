using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallApp {
    class SoccerBall : Obj {
        //フィールド
        private static int cnt;

        Random rand = new Random();

        //コンストラクタ
        public SoccerBall(double xp, double yp)
            : base(xp, yp, @"pic\soccer_ball.png") {

            int rndX = rand.Next(-10, 10);
            MoveX = (rndX != 0 ? rndX : 1);

            int rndY = rand.Next(-10, 10);
            MoveY = (rndY != 0 ? rndY : 1);
            cnt++;
        }

        public static int Cnt { get => cnt; set => cnt = value; }

        //メソッド
        public override void Move(PictureBox pbBar, PictureBox pbBall) {

            Rectangle rBar = new Rectangle(pbBar.Location.X, pbBar.Location.Y, 
                                                     pbBar.Width, pbBar.Height);

            Rectangle rBall = new Rectangle(pbBall.Location.X, pbBall.Location.Y,
                                                     pbBall.Width, pbBall.Height);

            if (PosY > 520 || PosY < 0 || rBall.IntersectsWith(rBar))
            {
                MoveY = -MoveY;
            }
            if (PosX > 730 || PosX < 0)
            {
                MoveX = -MoveX;
            }
            PosX += MoveX;
            PosY += MoveY;

        }
        public override void Move(Keys direction) {
            ;
        }
    }
}
