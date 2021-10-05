using System;
using System.Collections.Generic;
using System.Text;

namespace quizV2
{
    class QuestionHandler
    {

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
                GetNewQuestion(questions).PresentQuestion();
            }
        }
    }
}
