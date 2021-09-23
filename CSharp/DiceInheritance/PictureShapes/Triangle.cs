using System;
using System.Drawing;
using System.Threading;

namespace PictureShapes
{
    /// <summary>
    /// An object of this class represents a Triangle, that is painted on a canvas.
    /// 
    /// author: Rikard Karlsson
    /// 
    /// version: 2018 June
    /// </summary>
    class Triangle : Shape
    {
        public int Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
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
            }
        }
        /// <summary>
        /// Metod used by the class Canvas to draw the Triangle on the canvas.
        /// </summary>
        /// <param name="g">The Grapics object to draw on.</param>
        public override void Draw(Graphics g)
        {
            if (isVisible)
            {
                Color color = this.color;
                Point upperMiddle = new Point(xPosition + width / 2, yPosition);
                Point lowerLeft = new Point(xPosition, yPosition + width / 2);
                Point lowerRight = new Point(xPosition + width, yPosition + width / 2);
                Point [] points = { upperMiddle, lowerLeft, lowerRight };
                g.FillPolygon(new SolidBrush(color), points);
            }
        }

        /// <summary>
        /// Change the size of the Triangle.
        /// </summary>
        /// <param name="size">The new size in pixels.</param>
        public void ChangeSize(int size)
        {
            if (size > 0)
            {
                width = size;
            }
            Draw();
        }

        // Redraw the Triangle on the canvas. Make changes visible.
        private void Draw()
        {
            //Canvas canvas = Canvas.GetCanvas();
            Canvas canvas = Canvas.Self;
            canvas.Draw(this);

        }
    }
}