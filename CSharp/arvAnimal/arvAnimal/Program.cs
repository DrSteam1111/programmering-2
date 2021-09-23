using System;

class Program
{
    public static Zoo mittZoo = new Zoo();

    static void Main(string[] args)
    {
        mittZoo.addCat(2);
        mittZoo.addCat(1);
        mittZoo.addCat(4);
        mittZoo.addDog(3);
        mittZoo.addDog(2);
        mittZoo.addCow(2);

        mittZoo.Run();
    }
}

