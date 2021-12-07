using System.Collections.Generic;
using System.Windows;

namespace QuizWPF
{
    public partial class MainWindow : Window
    {
        QuizSqlHandler.SqlHandler sqlHandler;

        List<List<string>> list = new List<List<string>>();
        List<string> currentQuestion = new List<string>();

        int currentIndex = 0;
        int questionAmount = 0;
        int rightAnswers = 0;

        public MainWindow()
        {
            sqlHandler = new QuizSqlHandler.SqlHandler();
            InitializeComponent();
            SetupQuiz();
        }

        void SetupQuiz()
        {
            // Gets the amount of questions
            questionAmount = sqlHandler.GetIDsFromDatabase(sqlHandler.DatabaseConnection);
            // you start with full marks
            rightAnswers = questionAmount;
            // adds each question to a list of lists
            for (int i = 0; i < questionAmount; i++)
            {
                list.Add(sqlHandler.ReadFromDatabaseToList(sqlHandler.DatabaseConnection, i));
            }
            // Sets the first question
            currentQuestion = list[currentIndex];
            question.Text = currentQuestion[1];
        }

        private void answerBtn_Click(object sender, RoutedEventArgs e)
        {
            // checks answer
            if (currentQuestion[2] == answer.Text)
            {
                // does it exist
                if (questionAmount - 1 > currentIndex)
                {
                    // go to next question
                    currentIndex++;
                    currentQuestion = list[currentIndex];
                    question.Text = currentQuestion[1];
                    answer.Text = "Answer";
                } 
                else
                {
                    // no more questions
                    question.Text = "You Finished with a score of";
                    rightAnswered.Text = rightAnswers + "/" + questionAmount;
                    rightAnsweredBorder.Visibility = Visibility.Visible;
                    answerBorder.Visibility = Visibility.Collapsed;
                    answerBtn.Visibility = Visibility.Collapsed;
                }
            } 
            else
            {
                // deduct rightAnswers as you answered wrong
                rightAnswers--;
                // does the samething as if you answered right
                if (questionAmount - 1 > currentIndex)
                {
                    currentIndex++;
                    currentQuestion = list[currentIndex];
                    question.Text = currentQuestion[1];
                    answer.Text = "Answer";
                }
                else
                {
                    question.Text = "You Finished with a score of";
                    rightAnswered.Text = rightAnswers + "/" + questionAmount;
                    rightAnsweredBorder.Visibility = Visibility.Visible;
                    answerBorder.Visibility = Visibility.Collapsed;
                    answerBtn.Visibility = Visibility.Collapsed;
                }
            }
        }
    }
}
