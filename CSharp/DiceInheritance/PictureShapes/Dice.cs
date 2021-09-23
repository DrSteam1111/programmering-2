using System;
using System.Drawing;

namespace PictureShapes
{
    class Dice
    {
        private Circle dot0;
        private Circle dot1;
        private Circle dot2;
        private Circle dot3;
        private Circle dot4;
        private Circle dot5;
        private Circle dot6;

        private static Random numberGenerator;
        private static int rollNum;
        public Dice()
        {
            numberGenerator = new Random();
            rollNum = numberGenerator.Next(1, 7);

        }

        public void Roll()
        {
            DrawDice();
            switch (rollNum)
            {
                case 1:
                    dot0.IsVisable = true;
                    break;
                case 2:
                    dot1.IsVisable = true;
                    dot2.IsVisable = true;
                    break;
                case 3:
                    dot1.IsVisable = true;
                    dot0.IsVisable = true;
                    dot2.IsVisable = true;
                    break;
                case 4:
                    dot1.IsVisable = true;
                    dot3.IsVisable = true;
                    dot2.IsVisable = true;
                    dot4.IsVisable = true;
                    break;
                case 5:
                    dot1.IsVisable = true;
                    dot3.IsVisable = true;
                    dot0.IsVisable = true;
                    dot2.IsVisable = true;
                    dot4.IsVisable = true;
                    break;
                case 6:
                    dot1.IsVisable = true;
                    dot5.IsVisable = true;
                    dot3.IsVisable = true;
                    dot2.IsVisable = true;
                    dot6.IsVisable = true;
                    dot4.IsVisable = true;
                    break;
                default:
                    break;
            }
        }
        public void DrawDice()
        {
            dot0 = new Circle();
            dot0.IsVisable = false;
            dot0.SColor = Color.Red;
            dot0.ChangeSize(100);
            dot0.XPos = 250;
            dot0.YPos = 150;

            dot1 = new Circle();
            dot1.IsVisable = false;
            dot1.SColor = Color.Red;
            dot1.ChangeSize(100);
            dot1.XPos = 100;
            dot1.YPos = 0;

            dot3 = new Circle();
            dot3.IsVisable = false;
            dot3.SColor = Color.Red;
            dot3.ChangeSize(100);
            dot3.XPos = 100;
            dot3.YPos = 300;

            dot5 = new Circle();
            dot5.IsVisable = false;
            dot5.SColor = Color.Red;
            dot5.ChangeSize(100);
            dot5.XPos = 100;
            dot5.YPos = 150;

            dot4 = new Circle();
            dot4.IsVisable = false;
            dot4.SColor = Color.Red;
            dot4.ChangeSize(100);
            dot4.XPos = 400;
            dot4.YPos = 0;

            dot6 = new Circle();
            dot6.IsVisable = false;
            dot6.SColor = Color.Red;
            dot6.ChangeSize(100);
            dot6.XPos = 400;
            dot6.YPos = 150;

            dot2 = new Circle();
            dot2.IsVisable = false;
            dot2.SColor = Color.Red;
            dot2.ChangeSize(100);
            dot2.XPos = 400;
            dot2.YPos = 300;
        }
    }
}
