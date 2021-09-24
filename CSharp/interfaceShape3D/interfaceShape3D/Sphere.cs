using System;
using System.Collections.Generic;
using System.Text;

namespace interfaceShape3D
{
    class Sphere : Shape3D
    {
        private double r;

        public Sphere(double radien)
        {
            r = radien;
        }

        public double GetArea()
        {
            return 4 * Math.PI * r * r;
        }

        public double GetVolume()
        {
            return 4 * Math.PI * r * r * r / 3;
        }

        public override string ToString()
        {
            return "Sphere: \n radius: " + r.ToString();
        }
    }
}
