﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public override void Move() {
            if (PosY > 520 || PosY < 0)
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
    }
}
