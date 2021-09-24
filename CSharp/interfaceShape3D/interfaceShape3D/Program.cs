using System;

namespace interfaceShape3D
{
    class Program
    {
        static void Main(string[] args)
        {
            Database database = new Database();
            database.AddShape(new Sphere(4.0));
            database.AddShape(new Cylinder(4.0, 6.0));
            database.AddShape(new Cube(3.0));

            database.Print();
        }
    }
}
