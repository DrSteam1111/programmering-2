using System;
using System.Collections.Generic;
using System.Text;

namespace quizV2
{
    class QuestionDatabase
    {
        List<Question> database = new List<Question>();

        public void AddFreehandQuestion(string question, string answer)
        {
            database.Add(new FreehandQuestion(question, answer));
        }

        public void AddMultipleChoiceQuestion(string question, string answer, List<string> mulChoices)
        {
            database.Add(new MultipleChoiceQuestion(question, answer, mulChoices));
        }
        public void Add(Question question)
        {
            database.Add(question);
        }

        public List<Question> GetDatabase()
        {
            return database;
        }
    }
}
