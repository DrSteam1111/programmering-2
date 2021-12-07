namespace quizV2
{
    abstract class Question
    {
        protected string question;
        protected string answer;

        protected Question(string question, string answer)
        {
            this.question = question;
            this.answer = answer;
        }

        public abstract void PresentQuestion();

    }
}
