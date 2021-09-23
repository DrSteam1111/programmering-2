using System;

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
                    dot0.MakeVisible();
                    break;
                case 2:
                    dot1.MakeVisible();
                    dot2.MakeVisible();
                    break;
                case 3:
                    dot1.MakeVisible();
                    dot0.MakeVisible();
                    dot2.MakeVisible();
                    break;
                case 4:
                    dot1.MakeVisible();
                    dot3.MakeVisible();
                    dot2.MakeVisible();
                    dot4.MakeVisible();
                    break;
                case 5:
                    dot1.MakeVisible();
                    dot3.MakeVisible();
                    dot0.MakeVisible();
                    dot2.MakeVisible();
                    dot4.MakeVisible();
                    break;
                case 6:
                    dot1.MakeVisible();
                    dot5.MakeVisible();
                    dot3.MakeVisible();
                    dot2.MakeVisible();
                    dot6.MakeVisible();
                    dot4.MakeVisible();
                    break;
                default:
                    break;
            }
        }
        public void DrawDice()
        {
            dot0 = new Circle();
            dot0.MakeInVisible();
            dot0.ChangeColor("red");
            dot0.ChangeSize(100);
            dot0.MoveHorizontal(250);
            dot0.MoveVertical(150);

            dot1 = new Circle();
            dot1.MakeInVisible();
            dot1.ChangeColor("red");
            dot1.ChangeSize(100);
            dot1.MoveHorizontal(100);
            dot1.MoveVertical(0);

            dot3 = new Circle();
            dot3.MakeInVisible();
            dot3.ChangeColor("red");
            dot3.ChangeSize(100);
            dot3.MoveHorizontal(100);
            dot3.MoveVertical(300);

            dot5 = new Circle();
            dot5.MakeInVisible();
            dot5.ChangeColor("red");
            dot5.ChangeSize(100);
            dot5.MoveHorizontal(100);
            dot5.MoveVertical(150);

            dot4 = new Circle();
            dot4.MakeInVisible();
            dot4.ChangeColor("red");
            dot4.ChangeSize(100);
            dot4.MoveHorizontal(400);
            dot4.MoveVertical(0);

            dot6 = new Circle();
            dot6.MakeInVisible();
            dot6.ChangeColor("red");
            dot6.ChangeSize(100);
            dot6.MoveHorizontal(400);
            dot6.MoveVertical(150);

            dot2 = new Circle();
            dot2.MakeInVisible();
            dot2.ChangeColor("red");
            dot2.ChangeSize(100);
            dot2.MoveHorizontal(400);
            dot2.MoveVertical(300);
        }
    }
}
