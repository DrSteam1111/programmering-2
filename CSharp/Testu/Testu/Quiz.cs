using System;
using System.Collections.Generic;
using System.Text;

class Quiz
{
    public String[] question = new String[] { };
    public String[] answer = new String[] { };

    public void questions()
    {
        Console.WriteLine("Vad heter Norges huvudstad?");
        String a1 = Console.ReadLine();
        Console.WriteLine(checkAnswer(1, a1));
        Console.WriteLine("Vad heter Danmarks huvudstad?");
        String a2 = Console.ReadLine();
        Console.WriteLine(checkAnswer(2, a2));
        Console.WriteLine("Vad heter Finlands huvudstad?");
        String a3 = Console.ReadLine();
        Console.WriteLine(checkAnswer(3, a3));
    }

    private String checkAnswer(int question, String guess)
    {
        switch (question)
        {
            case 1:
                if (guess == "Oslo")
                {
                    return "Rätt";
                }
                else
                {
                    return "Fel!";
                }
            case 2:
                if (guess == "Köpenhamn")
                {
                    return "Rätt";
                }
                else
                {
                    return "Fel!";
                }
            case 3:
                if (guess == "Helsingfors")
                {
                    return "Rätt";
                }
                else
                {
                    return "Fel!";
                }
            default:
                return "0";
        }
    }
}

