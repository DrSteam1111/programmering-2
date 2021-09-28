using System.Collections.Generic;

namespace quizApp
{
    class Program
    {
        /*
         *          Questions Variables
         */

        public static string question1 = " 1. When was C# invented?\n";
        public static string answer1 = "2000";
        public static List<string> possibleAnswers1 = new List<string>()
        {
            " 1983",
            " 2002",
            " 2000",
            " 1995",
            " 2012"
        };

        public static string question2 = " 2. Who invented C#?\n";
        public static string answer2 = "Anders Hejlsberg";
        public static List<string> possibleAnswers2 = new List<string>()
        {
            " Anders Hejlsberg",
            " D. Luffy",
            " Linus Torvalds",
            " The Rock",
            " Bjarne Stroustrup"
        };

        public static string question3 = " 3. The dog doing?\n";
        public static string answer3 = "What the dog doin?";
        public static List<string> possibleAnswers3 = new List<string>()
        {
            " What the dog doin?",
            " Walking",
            " Eating",
            " Sleeping",
            " Nothing"
        };

        /*
         *          Questions Variables
         */

        static void Main(string[] args)
        {
            CsharpQuizQuestions();
        }

        private static void CsharpQuizQuestions()
        {
            Questions question = new Questions();
            while (question.ReadQuestions(question1, answer1, possibleAnswers1));
            while (question.ReadQuestions(question2, answer2, possibleAnswers2));
            while (question.ReadQuestions(question3, answer3, possibleAnswers3));
            question.YouWon();
        }
    }
}
