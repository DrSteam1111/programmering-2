using System;
using System.Collections.Generic;
using System.Text;

namespace quizV2
{
    class FreehandQuestion : Question
    {
        public FreehandQuestion(string question, string answer) 
            : base(question, answer)
        {
        }

        public override void PresentQuestion()
        {
            Console.Clear();
            Console.WriteLine(ToString());
            Console.Write("Answer: ");
            while (Console.ReadLine().ToLower() != answer.ToLower());
            Console.Clear();
            Console.WriteLine("    Correct!");
        }

        public override string ToString()
        {
            return question + "\n";
        }
    }
}
