using System;

namespace quizV2
{
    class Program
    {
        static void Main(string[] args)
        {
            QuestionDatabase questionDatabase = new QuestionDatabase();
            QuestionHandler questionHandler = new QuestionHandler();

            var connection = questionDatabase.ConnectDatabase();
            questionDatabase.ReadFromDatabaseAndAdd(connection);

            // --- Does nothing yet -------
            questionDatabase.WriteToDatabase(connection);
            // ----------------------------

            questionHandler.Present(questionDatabase.GetDatabase());
        }
    }
}
