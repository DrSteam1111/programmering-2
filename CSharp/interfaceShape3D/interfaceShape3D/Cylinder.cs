using System;
using System.Collections.Generic;
using System.Text;

namespace interfaceShape3D
{
    class Cylinder : Shape3D
    {
        private double r;
        private double h;

        public Cylinder(double radien, double height)
        {
            r = radien;
            h = height;
        }

        public double GetArea()
        {
            return 2 * Math.PI * r * h + 2 * Math.PI * Math.Pow(r, 2);
        }

        public double GetVolume()
        {
            return Math.PI * Math.Pow(r, 2) * h;
        }

        public override string ToString()
        {
            return "Cylinder:\n radius: " + r + "\n height: " + h;
        }
    }
}
