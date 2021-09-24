using System;
using System.Collections.Generic;
using System.Text;

namespace interfaceShape3D
{
    class Database
    {
        List<Shape3D> shapes = new List<Shape3D>();

        public void Print()
        {
            for (int i = 0; i < shapes.Count; i++)
            {
                Console.WriteLine(shapes[i].ToString());
                Console.WriteLine(" Area = " + shapes[i].GetArea());
                Console.WriteLine(" Volume = " + shapes[i].GetVolume());
                Console.WriteLine();
            }
        }

        public void AddShape(Shape3D shape)
        {
            shapes.Add(shape);
        }
    }
}
