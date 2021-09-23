using System;
using System.Drawing;
using System.Threading;

namespace PictureShapes
{
    /// <summary>
    /// An object of this class represents a Square, that is painted on a canvas.
    /// 
    /// author: Rikard Karlsson
    /// 
    /// version: 2018 June
    /// </summary>
    class Square : Shape
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
        /// Metod used by the class Canvas to draw the Square on the canvas.
        /// </summary>
        /// <param name="g">The Grapics object to draw on.</param>
        public override void Draw(Graphics g)
        {
            if (isVisible)
            {
                Color color = this.color;
                g.FillRectangle(new SolidBrush(color), xPosition, yPosition, width, width);
            }
        }

        // Redraw the Square on the canvas. Make changes visible.
        private void Draw()
        {
            //Canvas canvas = Canvas.GetCanvas();
            Canvas canvas = Canvas.Self;
            canvas.Draw(this);
        }
    }
}