using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallApp {
    //抽象クラス
    abstract class Obj {
        private Image image; //画像データ

        private double posX; //x座標
        private double posY; //y座標
        private double moveX; //移動量（x方向）
        private double moveY; //移動量（y方向）
        private int cnt1;
        private int cnt2;
      

        //プロパティ
        public double PosX { get => posX; set => posX = value; }
        public double PosY { get => posY; set => posY = value; }
        public Image Image { get => image; set => image = value; }
        public double MoveX { get => moveX; set => moveX = value; }
        public double MoveY { get => moveY; set => moveY = value; }
        public int Cnt1 { get => cnt1; set => cnt1 = value; }
        public int Cnt2 { get => cnt2; set => cnt2 = value; }

        //コンストラクタ
        public Obj(double PosX,double PosY,string Path) {
            this.PosX = PosX;
            this.PosY = PosY;
            Image = Image.FromFile(Path);
       

            //後ほど追加
        }

        //移動メソッド(抽象メソッド)
        public abstract void Move(PictureBox pbBar,PictureBox pbBall);
        public abstract void Move(Keys direction);
    }
}

