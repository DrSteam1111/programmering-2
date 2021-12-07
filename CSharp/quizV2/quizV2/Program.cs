using System.Linq;
using System.Collections.Generic;

namespace quizV2
{
    class Program
    {
        static void Main(string[] args)
        {
            QuestionDatabase questionDatabase = new QuestionDatabase();
            QuestionHandler questionHandler = new QuestionHandler();

            List<string> questions = questionHandler.ReadQuestionFile();

            foreach (string item in questions)
            {
                string[] options = item.Split("-");
                if(options[0] == "F")
                {
                    questionDatabase.AddFreehandQuestion(options[1], options[2]);
                } 
                else if(options[0] == "M")
                {
                    string[] arrayChoises = options[3].Split(",");
                    List<string> listChoies = arrayChoises.OfType<string>().ToList();
                    questionDatabase.AddMultipleChoiceQuestion(options[1], options[2], listChoies);
                }
            }

            //questionDatabase.AddFreehandQuestion("is this a question?", "yes");
            //questionDatabase.AddMultipleChoiceQuestion("is this a question", "2", 
            //new List<string>() { "1. Yes", "2. No", "3. Maybe" });

            questionHandler.Present(questionDatabase.GetDatabase());
        }
    }
}
