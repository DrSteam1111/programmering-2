using System;
using System.Windows;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

class Solution
{
    public Solution()
    {
    }

    public void Uppgift_1A()
    {
        Console.Write("Namn: ");
        String name = Console.ReadLine();
        Console.WriteLine("Hej! " + name + ". Varmt välkommen.");
    }

    public void Uppgift_1B()
    {
        float width = 9.6f;
        float height = 5.4f;
        float area = width * height;
        Console.WriteLine("Bredd: " + width);
        Console.WriteLine("Höjd: " + height);
        Console.WriteLine("Area: " + area);
    }

    public void Uppgift_1C()
    {
        Console.Write("Bredd: ");
        String widthInText = Console.ReadLine();
        Console.WriteLine();
        Console.Write("Höjd: ");
        String heightInText = Console.ReadLine();
        Console.WriteLine();

        double width = Convert.ToDouble(widthInText);
        double height = Convert.ToDouble(heightInText);
        double area = width * height;

        Console.WriteLine("Bredd: " + width);
        Console.WriteLine("Höjd: " + height);
        Console.WriteLine("Area: " + area);
    }

    public void Uppgift_1D()
    {
        Console.Write("value 1: ");
        String value1InText = Console.ReadLine();
        Console.WriteLine();
        Console.Write("value 2: ");
        String value2InText = Console.ReadLine();
        Console.WriteLine();

        double convertedV1 = Convert.ToDouble(value1InText);
        double convertedV2 = Convert.ToDouble(value2InText);

        Console.WriteLine("Summan: " + (convertedV1 + convertedV2));
    }

    public void Uppgift_2A()
    {
        Console.Write("Giassa Mitt Favorittal: ");
        String gissning = Console.ReadLine();

        if (gissning == "3")
        {
            Console.WriteLine("Gissa rätt");
        }
        else
        {
            Console.WriteLine("Fel!");
        }
    }

    public void Uppgift_2B()
    {
        Random rand = new Random();
        double rand1 = rand.Next(1, 7);
        double rand2 = rand.Next(1, 7);

        if (rand1 == rand2)
        {
            Console.WriteLine("You Won!");
        }
        else
        {
            Console.WriteLine("You Lose!");
        }
    }

    public void Uppgift_3A()
    {
        int i = 1;
        while(i <= 5)
        {
            Console.Write(i + ", ");
            i++;
        }
    }

    public void Uppgift_3B()
    {
        int i = 5;
        while (i <= 20)
        {
            Console.Write(i + ", ");
            i = i + 3;
        }
    }

    public void Uppgift_3C()
    {
        int i = 10;
        while (i >= 0)
        {
            Console.Write(i + ", ");
            i--;
        }
    }

    public void Uppgift_4A()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.Write(i + ", ");
        }
    }

    public void Uppgift_4B()
    {
        for (int i = 5; i <= 20; i = i + 3)
        {
            Console.Write(i + ", ");
        }
    }

    public void Uppgift_4C()
    {
        for (int i = 10; i >= 0; i--)
        {
            Console.Write(i + ", ");
        }
    }

    public void Uppgift_5()
    {
        bool stillNotRight = true; 
        while(stillNotRight)
        {
            Console.Write("Gissa nummeret: ");
            String guess = Console.ReadLine();
            if(guess == "15")
            {
                Console.WriteLine("Du gissa Rätt!");
                stillNotRight = false;
            }
        }
    }

    public void Uppgift_6()
    {
        Random rand = new Random();
        int rand1 = rand.Next(1, 7);
        int rand2 = rand.Next(1, 7);

        Console.Write("Tärning A är " + rand1 + " och Tärning B är " + rand2 + "\n");

        if(rand1 == 6 && rand2 == 6)
        {
            Console.WriteLine("Storvinst!");
        }
        else if (rand1 == rand2)
        {
            Console.WriteLine("Liten Vinst!");
        }
        else
        {
            Console.WriteLine("Förlust!");
        }
    }

    public void Uppgift_7()
    {
        int[] a = new int[6] { 3, 5, 7, 9, 11, 13 };
        for (int i = 0; i < a.Length; i++)
        {
            Console.Write(a[i] + ", ");
        }
    }

    public void Uppgift_8A()
    {
        int[] a = new int[6] { 3, 5, 7, 9, 11, 13 };
        foreach (int e in a)
        {
            Console.Write(e + ", ");
        }
    }

    public void Uppgift_8B()
    {
        int[] a = new int[6] { 3, 5, 7, 9, 11, 13 };
        foreach (int e in a)
        {
            Console.Write((e + 1) + ", ");
        }
    }

    public String Uppgift_9A()
    {
        return "Välkommen Agent X. Ditt uppdrag är... ";
    }

    public void Uppgift_9B()
    {
        Console.WriteLine(Addera(192, 8));
        Console.WriteLine(Addera3(58, 28, 12));
    }

    public int Addera(int a, int b)
    {
        return a + b;
    }
    public int Addera3(int a, int b, int c)
    {
        return a + b + c;
    }

    public void Uppgift_10()
    {
        String[] varor = new String[400];
        bool IsNotDone = true;
        int pos = 0;
        
        while(IsNotDone)
        {
            Console.Write("To Add: ");
            String toadd = Console.ReadLine();
            Console.WriteLine();
            if (toadd == "e")
            {
                IsNotDone = false;
            }
            else
            {
                varor[pos] = toadd;
                pos++;
            }
        }

        Console.WriteLine("Här är Inköpslistan");
        PrintValues(varor);
    }

    public static void PrintValues(Object[] arr)
    {
        foreach (Object i in arr)
        {
            Console.WriteLine("\t{0}", i);
        }
    }
}