using System;
using System.Collections.Generic;

namespace quizV2
{
    class Program
    {
        static void Main(string[] args)
        {
            QuestionDatabase questionDatabase = new QuestionDatabase();
            QuestionHandler questionHandler = new QuestionHandler();

            questionDatabase.AddFreehandQuestion("is this a question?", "yes");
            questionDatabase.AddMultipleChoiceQuestion("is this a question", "2", 
                new List<string>() { "1. Yes", "2. No", "3. Maybe" });

            questionHandler.Present(questionDatabase.GetDatabase());
        }
    }
}
