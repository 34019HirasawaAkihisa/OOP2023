using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallApp {
    class SoccerBall {
        //フィールド
        private Image image; //画像データ

        private double posX; //x座標
        private double posY; //y座標

        private double moveX; //移動量（x方向）
        private double moveY; //移動量（y方向）

        Random rand = new Random();

        //コンストラクタ
        public SoccerBall(double xp,double yp) {
            
            Image = Image.FromFile(@"pic\soccer_ball.png");
            posX = xp;
            posY = yp;

            int rndX = rand.Next(-10, 10);
            moveX = (rndX != 0 ? rndX : 1);
            int rndY = rand.Next(-10, 10);
            moveY = (rndY != 0 ? rndY : 1);
        }

        //プロパティ
        public double PosX { get => posX; set => posX = value; }
        public double PosY { get => posY; set => posY = value; }
        public Image Image { get => image; set => image = value; }

        //メソッド
        public void Move() {
            if (posY > 520 || posY < 0)
            {
                moveY = -moveY;
            }
            if (posX > 730 || posX < 0)
            {
                moveX = -moveX;
            }
           
            posX += moveX;
            posY += moveY;


        }
    }
}
