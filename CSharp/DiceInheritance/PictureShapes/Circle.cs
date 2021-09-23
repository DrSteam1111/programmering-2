using System;
using System.Drawing;
using System.Threading;

namespace PictureShapes
{
    /// <summary>
    /// An object of this class represents a Circle, that is painted on a canvas.
    /// 
    /// author: Rikard Karlsson
    /// 
    /// version: 2018 June
    /// </summary>
    class Circle : Shape
    {
        private int diameter;

        public int Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
                Draw();
            }
        }
        public int XPos
        {
            get
            {
                return xPosition;
            }
            set
            {
                xPosition = value;
                Draw();
            }
        }
        public int YPos
        {
            get
            {
                return yPosition;
            }
            set
            {
                yPosition = value;
                Draw();
            }
        }
        public bool IsVisable
        {
            get
            {
                return isVisible;
            }
            set
            {
                isVisible = value;
                Draw();
            }
        }
        public Color SColor
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
                Draw();
            }
        }

        /// <summary>
        /// Constructor used to create a Circle object.
        /// </summary>
        public Circle()
        {
            diameter = 50;
        }

        /// <summary>
        /// Metod used by the class Canvas to draw the Circle on the canvas.
        /// </summary>
        /// <param name="g">The Grapics object to draw on.</param>
        public override void Draw(Graphics g)
        {
            if (isVisible)
            {
                Color color = this.color;
                g.FillEllipse(new SolidBrush(color), xPosition, yPosition, diameter, diameter); //only difference
                //Wait(10);
            }
        }

        /// <summary>
        /// Change the size of the Circle.
        /// </summary>
        /// <param name="size">The new size in pixels.</param>
        public void ChangeSize(int size)
        {
            if (size > 0)
            {
                diameter = size;
            }
            Draw();
        }


        // Redraw the circle on the canvas. Make changes visible.
        private void Draw()
        {
            //Canvas canvas = Canvas.GetCanvas();
            Canvas canvas = Canvas.Self;
            canvas.Draw(this);

        }
    }
}