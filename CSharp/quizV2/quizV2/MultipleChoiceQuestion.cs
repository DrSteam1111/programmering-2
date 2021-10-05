using System;
using System.Collections.Generic;
using System.Text;

namespace quizV2
{
    class MultipleChoiceQuestion : Question
    {
        protected List<string> mulChoices;

        public MultipleChoiceQuestion(string question, string answer, List<string> mulChoices) 
            : base(question, answer)
        {
            this.mulChoices = mulChoices;
        }

        public override void PresentQuestion()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(ToString());
            Console.Write("Answer: ");
            while (Console.ReadLine().ToLower() != answer.ToLower())
            Console.Clear();
            Console.WriteLine("    Correct!");
        }

        public override string ToString()
        {
            if (mulChoices.Count == 0 || mulChoices == null)
                return question + "\n\n";
            return question + "\n" + string.Join("\n", mulChoices) + "\n";
        }

    }
}
