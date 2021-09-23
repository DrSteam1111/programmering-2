using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PictureShapes
{

    public abstract class Shape
    {
        protected int width = 0;
        protected int xPosition = 0;
        protected int yPosition = 0;
        protected bool isVisible = false;
        protected Color color = Color.Black;

        public abstract void Draw(Graphics g);
    }
}
