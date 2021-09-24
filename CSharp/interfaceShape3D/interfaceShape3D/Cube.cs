using System;
using System.Collections.Generic;
using System.Text;

namespace interfaceShape3D
{
    class Cube : Shape3D
    {
        private double len;

        public Cube(double length)
        {
            len = length;
        }

        public double GetArea()
        {
            return 6 * Math.Pow(len, 2);
        }

        public double GetVolume()
        {
            return Math.Pow(len, 3);
        }

        public override string ToString()
        {
            return "Cube: \n length of side: " + len;
        }
    }
}
