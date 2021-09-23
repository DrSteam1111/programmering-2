using System;
using System.Collections.Generic;
using System.Text;


class Dog
{
    private int age;
    public Dog(int a)
    {
        age = a;
    }

    public void Act()
    {
        for (int i = 0; i < age; i++)
        {
            Console.WriteLine("vov, vov, vov");
        }
    }
}

