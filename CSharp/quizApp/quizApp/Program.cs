using System;
using QuizLibrary;

namespace quizApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CsharpQuizQuestions();

            Console.ReadLine();
        }

        private static void CsharpQuizQuestions()
        {
            Questions question = new Questions();
            question.QuestionOne();

            Console.Clear();
        }
    }
}
