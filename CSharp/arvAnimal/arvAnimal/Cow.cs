using System;
using System.Collections.Generic;
using System.Text;

class Cow
{
    private int age;
    public Cow(int a)
    {
        age = a;
    }

    public void Act()
    {
        for (int i = 0; i < age; i++)
        {
            Console.WriteLine("Mu, Muu");
        }
    }
}

