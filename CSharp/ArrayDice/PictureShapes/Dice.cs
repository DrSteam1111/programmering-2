using System;

namespace PictureShapes
{
    class Dice
    {
        private Circle[] dots = new Circle[] { new Circle(), new Circle(), new Circle(), new Circle(), new Circle(), new Circle(), new Circle() };

        private int xpos;
        private int ypos;
        private int size;

        private static Random numberGenerator;
        private static int rollNum;

        public int XPos
        {
            get
            {
                return xpos;
            }
            set
            {
                xpos = value;
            }
        }

        public int YPos
        {
            get
            {
                return ypos;
            }
            set
            {
                ypos = value;
            }
        }

        public int Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
            }
        }

        public Dice()
        {
            numberGenerator = new Random();
            rollNum = numberGenerator.Next(1, 7);
            XPos = 100;
            Size = 20;
        }

        public void Roll()
        {
            DrawDice();
            switch (rollNum)
            {
                case 1:
                    dots[0].MakeVisible();
                    break;
                case 2:
                    dots[1].MakeVisible();
                    dots[2].MakeVisible();
                    break;
                case 3:
                    dots[1].MakeVisible();
                    dots[0].MakeVisible();
                    dots[2].MakeVisible();
                    break;
                case 4:
                    dots[1].MakeVisible();
                    dots[3].MakeVisible();
                    dots[2].MakeVisible();
                    dots[4].MakeVisible();
                    break;
                case 5:
                    dots[1].MakeVisible();
                    dots[3].MakeVisible();
                    dots[0].MakeVisible();
                    dots[2].MakeVisible();
                    dots[4].MakeVisible();
                    break;
                case 6:
                    dots[1].MakeVisible();
                    dots[5].MakeVisible();
                    dots[3].MakeVisible();
                    dots[2].MakeVisible();
                    dots[6].MakeVisible();
                    dots[4].MakeVisible();
                    break;
                default:
                    break;
            }
        }
        public void DrawDice()
        {
            dots[0].MakeInVisible();
            dots[0].ChangeColor("red");
            dots[0].ChangeSize(size);
            dots[0].xPos = 250 + XPos - size;
            dots[0].yPos = 150 + YPos + size;

            dots[1].MakeInVisible();
            dots[1].ChangeColor("red");
            dots[1].ChangeSize(size);
            dots[1].xPos = 100 + XPos - size;
            dots[1].yPos = 0 + YPos + size;

            dots[3].MakeInVisible();
            dots[3].ChangeColor("red");
            dots[3].ChangeSize(size);
            dots[3].xPos = 100 + XPos - size;
            dots[3].yPos = 300 + YPos + size;

            dots[5].MakeInVisible();
            dots[5].ChangeColor("red");
            dots[5].ChangeSize(size);
            dots[5].xPos = 100 + XPos - size;
            dots[5].yPos = 150 + YPos + size;

            dots[4].MakeInVisible();
            dots[4].ChangeColor("red");
            dots[4].ChangeSize(size);
            dots[4].xPos = 400 + XPos - size;
            dots[4].yPos = 0 + YPos + size;

            dots[6].MakeInVisible();
            dots[6].ChangeColor("red");
            dots[6].ChangeSize(size);
            dots[6].xPos = 400 + XPos - size;
            dots[6].yPos = 150 + YPos + size;

            dots[2].MakeInVisible();
            dots[2].ChangeColor("red");
            dots[2].ChangeSize(size);
            dots[2].xPos = 400 + XPos - size;
            dots[2].yPos = 300 + YPos + size;
        }
    }
}
