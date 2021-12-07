using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace quizV2
{
    class QuestionHandler
    {
        //public List<string> ReadQuestionFile()
        //{
        //    string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        //    string pathAndFileName = Path.Combine(docPath, "questions.txt");
        //    List<string> fileContent = new List<string>();

        //    try
        //    {
        //        using (var sr = new StreamReader(pathAndFileName))
        //        {
        //            string row = sr.ReadLine();
        //            while (row != null)
        //            {
        //                fileContent.Add(row);
        //                row = sr.ReadLine();
        //            }
        //            return fileContent;
        //        }
        //    }
        //    catch (FileLoadException e)
        //    {
        //        if (e.Data != null)
        //        {
        //            Console.WriteLine(e.Message);
        //            Console.WriteLine(e.Data);
        //        }
        //        throw;
        //    }
        //}

        private Question GetNewQuestion(List<Question> questions)
        {
            Question nq = questions[questions.Count - 1];
            questions.RemoveAt(questions.Count - 1);
            return nq;
        }

        public void Present(List<Question> questions)
        {
            while(questions.Count != 0)
            {
                Thread.Sleep((int)TimeSpan.FromSeconds(1).TotalMilliseconds);
                GetNewQuestion(questions).PresentQuestion();
            }
        }
    }
}
