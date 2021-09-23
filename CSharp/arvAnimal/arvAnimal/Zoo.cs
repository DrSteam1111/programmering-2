using System;
using System.Collections.Generic;
using System.Text;

class Zoo
{
    List<Cat> cats = new List<Cat>();
    List<Dog> dogs = new List<Dog>();
    List<Cow> cows = new List<Cow>();

    public void addCat(int a)
    {
        cats.Add(new Cat(a));
    }

    public void addDog(int a)
    {
        dogs.Add(new Dog(a));
    }
    public void addCow(int a)
    {
        cows.Add(new Cow(a));
    }

    public void Run()
    {
        for (int i = 0; i < cats.Count; i++)
        {
            cats[i].Act();
        }
        for (int i = 0; i < dogs.Count; i++)
        {
            dogs[i].Act();
        }
        for (int i = 0; i < cows.Count; i++)
        {
            cows[i].Act();
        }
    }
}

