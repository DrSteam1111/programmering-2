using System;
using System.Collections.Generic;
using Microsoft.Data.Sqlite;

namespace QuizSqlHandler
{
    public class SqlHandler
    {
        private SqliteConnection databaseConnection;

        public SqliteConnection DatabaseConnection
        {
            get { return databaseConnection; }
        }

        public SqlHandler()
        {
            var connectionStringBuilder = new SqliteConnectionStringBuilder();
            connectionStringBuilder.DataSource = "./QuestionDB.db";

            using (var connection = new SqliteConnection(connectionStringBuilder.ConnectionString))
            {
                connection.Open();

                var createTableCmd = connection.CreateCommand();
                createTableCmd.CommandText = "CREATE TABLE IF NOT EXISTS questions (id INTEGER PRIMARY KEY AUTOINCREMENT, type VARCHAR(128) NOT NULL, question VARCHAR(128) NOT NULL, answer VARCHAR(128) NOT NULL)";
                createTableCmd.ExecuteNonQuery();

                databaseConnection = connection;
                connection.Close();
            }
        }

        public int GetIDsFromDatabase(SqliteConnection connection)
        {
            connection.Open();
            int finalResult;

            using (var command = connection.CreateCommand())
            {
                command.CommandText = "SELECT COUNT(id) FROM questions;";
                command.CommandType = System.Data.CommandType.Text;
                finalResult = Convert.ToInt32(command.ExecuteScalar());
            }
            connection.Close();
            return finalResult;
        }

        public List<string> ReadFromDatabaseToList(SqliteConnection connection, int id)
        {
            connection.Open();
            List<string> list = new List<string>();

            var command = connection.CreateCommand();
            command.CommandText =
            @"
                SELECT type,question,answer
                FROM questions
                WHERE id = $id
            ";
            command.Parameters.AddWithValue("$id", id);

            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    list.Add(reader.GetString(0));
                    list.Add(reader.GetString(1));
                    list.Add(reader.GetString(2));
                    connection.Close();
                    return list;
                }
            }
            connection.Close();
            return new List<string> { "F", "Question?", "Answer" };
        }

        public void UpdateDatabase(SqliteConnection connection, string id, string type, string question, string answer)
        {
            connection.Open();

            using (var command = connection.CreateCommand())
            {
                command.CommandText = "UPDATE questions SET type=@type,question = @question,answer = @answer WHERE id = @id;";

                command.Parameters.AddWithValue("type", type);
                command.Parameters.AddWithValue("question", question);
                command.Parameters.AddWithValue("answer", answer);
                command.Parameters.AddWithValue("id", id);

                command.ExecuteReader();
            }

            connection.Close();
        }

        public void AddToDatabase(SqliteConnection connection, string type, string question, string answer)
        {
            connection.Open();

            using (var command = connection.CreateCommand())
            {
                command.CommandText = "INSERT INTO questions(type, question, answer) VALUES(@type, @question, @answer)";

                command.Parameters.AddWithValue("type", type);
                command.Parameters.AddWithValue("question", question);
                command.Parameters.AddWithValue("answer", answer);

                command.ExecuteNonQuery();
            }

            connection.Close();
        }

        public void RemoveFromDatabase(SqliteConnection connection, int questionID)
        {
            connection.Open();

            using (var command = connection.CreateCommand())
            {
                // Use parameterized query to prevent SQL injection attacks
                command.CommandText = "DELETE FROM questions WHERE id=@id";

                command.Parameters.AddWithValue("@id", questionID);

                command.ExecuteReader();
            }

            connection.Close();
        }

    }
}