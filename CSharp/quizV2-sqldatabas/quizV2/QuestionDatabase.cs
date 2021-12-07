using System.Collections.Generic;
using System.Linq;
using Microsoft.Data.Sqlite;

namespace quizV2
{
    class QuestionDatabase
    {
        // SQLite Handlers
        public SqliteConnection ConnectDatabase()
        {
            var connectionStringBuilder = new SqliteConnectionStringBuilder();
            connectionStringBuilder.DataSource = "./QuestionDB.db";
            
            using (var connection = new SqliteConnection(connectionStringBuilder.ConnectionString))
            {
                connection.Open();

                var createTableCmd = connection.CreateCommand();
                createTableCmd.CommandText = "CREATE TABLE IF NOT EXISTS questions (id INTEGER PRIMARY KEY AUTOINCREMENT, type VARCHAR(128) NOT NULL, question VARCHAR(128) NOT NULL, answer VARCHAR(128) NOT NULL)";
                createTableCmd.ExecuteNonQuery();

                connection.Close();
                return connection;
            }
        }

        public Question ReadQuestionFromDatabase(SqliteConnection connection)
        {
            connection.Open();

            using (var command = connection.CreateCommand())
            {
                command.CommandText = "SELECT type,question,answer from questions;";
                var result = command.ExecuteReader();
                while (result.Read())
                {
                    if (result.GetString(0) == "M")
                    {
                        string questionAndMulC = result.GetString(1);
                        string[] questionMulCO = questionAndMulC.Split("-");
                        string[] arrayChoises = questionMulCO[1].Split(",");
                        List<string> listChoies = arrayChoises.OfType<string>().ToList();
                        //AddMultipleChoiceQuestion(questionMulCO[0], result.GetString(2), listChoies);
                        return new MultipleChoiceQuestion(questionMulCO[0], result.GetString(2), listChoies);
                    }
                    else if (result.GetString(0) == "F")
                    {
                        //AddFreehandQuestion(result.GetString(1), result.GetString(2));
                        return new FreehandQuestion(result.GetString(1), result.GetString(2));
                    }
                }
            }
            return null;
        }

        public void ReadFromDatabaseAndAdd(SqliteConnection connection)
        {
            connection.Open();

            using (var command = connection.CreateCommand())
            {
                command.CommandText = "SELECT type,question,answer from questions;";
                var result = command.ExecuteReader();
                while (result.Read())
                {
                    if (result.GetString(0) == "M")
                    {
                        string questionAndMulC = result.GetString(1);
                        string[] questionMulCO = questionAndMulC.Split("-");
                        string[] arrayChoises = questionMulCO[1].Split(",");
                        List<string> listChoies = arrayChoises.OfType<string>().ToList();
                        AddMultipleChoiceQuestion(questionMulCO[0], result.GetString(2), listChoies);
                    }
                    else if (result.GetString(0) == "F")
                    {
                        AddFreehandQuestion(result.GetString(1), result.GetString(2));
                    }
                }
            }
            connection.Close();
        }

        public void WriteToDatabase(SqliteConnection connection)
        {
            connection.Open();
            // TODO Implement
            connection.Close();
        }


        // List handlers
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
