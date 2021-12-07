using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace QuizAdmin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataGridQuestions();
        }

        private void Button_ClickAdd(object sender, RoutedEventArgs e)
        {

        }

        private void Button_ClickSave(object sender, RoutedEventArgs e)
        {

        }

        public void DataGridQuestions()
        {
            List<Questions> questionlist = new List<Questions>();

            foreach (string item in ReadQuestionFile())
            {
                List<string> itemlist = item.Split("-").OfType<string>().ToList();
                itemlist.Add("");
                questionlist.Add(new Questions { QuestioType = itemlist[0], Question = itemlist[1], Answer = itemlist[2], MulChoices = itemlist[3] });
            }

            dgQuestions.ItemsSource = questionlist;
        }

        public List<string> ReadQuestionFile()
        {
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string pathAndFileName = System.IO.Path.Combine(docPath, "questions.txt");
            List<string> fileContent = new List<string>();

            try
            {
                using (var sr = new StreamReader(pathAndFileName))
                {
                    string row = sr.ReadLine();
                    while (row != null)
                    {
                        fileContent.Add(row);
                        row = sr.ReadLine();
                    }
                    return fileContent;
                }
            }
            catch (FileLoadException e)
            {
                if (e.Data != null)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine(e.Data);
                }
                throw;
            }

        }

        private void dgQuestions_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }

    public class Questions
    {
        public string QuestioType { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public string MulChoices { get; set; }
    }
}
