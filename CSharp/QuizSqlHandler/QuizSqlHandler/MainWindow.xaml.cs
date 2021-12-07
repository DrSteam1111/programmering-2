using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace QuizSqlHandler
{
    public partial class MainWindow : Window
    {
        List<Button> buttons = new List<Button>();
        SqlHandler sqlHandler;
        int currentID = 0;

        public MainWindow()
        {
            sqlHandler = new SqlHandler();
            InitializeComponent();
            CreateButtons();
        }

        private void CreateButtons()
        {
            for (int i = 0; i < sqlHandler.GetIDsFromDatabase(sqlHandler.DatabaseConnection); i++)
            {
                buttons.Add(new Button());
            }

            foreach (Button btn in buttons)
            {
                btn.Name = "btnis" + currentID;
                btn.Click += OnIDButtonClick;
                btn.Background = new SolidColorBrush(Colors.CadetBlue);
                btn.BorderBrush = new SolidColorBrush(Colors.Black);
                btn.Content = "ID: " + currentID;

                currentID++;
                btnsSP.Children.Add(btn);
            }
            
            btnsSP.Height = buttons.Count * 100;
        }

        private void UpdateButtons(bool remove)
        {
            if (remove)
            {
                if (currentID <= sqlHandler.GetIDsFromDatabase(sqlHandler.DatabaseConnection))
                {
                    Button btn = buttons[currentID];
                    btnsSP.Children.Remove(btn);
                    buttons.Remove(btn);
                    for (int i = 0; i < buttons.Count; i++)
                    {
                        buttons[i].Content = "ID: " + i;
                    }
                }
                else
                {
                    currentID = 0;
                    UpdateButtons(false);
                }
            }
            else
            {
                Button btn = new Button();
                btn.Name = "btnis" + (buttons.Count);
                btn.Click += OnIDButtonClick;
                btn.Background = new SolidColorBrush(Colors.CadetBlue);
                btn.BorderBrush = new SolidColorBrush(Colors.Black);
                btn.Content = "ID: " + (buttons.Count);

                btnsSP.Height = (buttons.Count) * 100;
                btnsSP.Children.Add(btn);
                buttons.Add(btn);
            }
        }

        private void OnIDButtonClick(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            if (btn == null)
                return;
            int id = Convert.ToInt32(btn.Content.ToString().Substring(4));
            currentID = id;

            List<string> questionToEdit = sqlHandler.ReadFromDatabaseToList(sqlHandler.DatabaseConnection, id);

            tbType.IsChecked = questionToEdit[0] == "M" ? true : false; 
            tbQuestion.Text = questionToEdit[1];
            tbAnswer.Text = questionToEdit[2];
        }

        private void OnSaveButtonClick(object sender, RoutedEventArgs e)
        {
            string type = "F";
            if (tbType.IsChecked == true)
                type = "M";
            sqlHandler.UpdateDatabase(sqlHandler.DatabaseConnection, currentID.ToString(), type, tbQuestion.Text, tbAnswer.Text);
        }

        private void OnAddButtonClick(object sender, RoutedEventArgs e)
        {
            sqlHandler.AddToDatabase(sqlHandler.DatabaseConnection, "F", "Question?", "Answer");
            UpdateButtons(false);
        }
        private void OnRemoveButtonClick(object sender, RoutedEventArgs e)
        {
            // HELP THE TABLE IT'S BROKEN
            UpdateButtons(true);
            sqlHandler.RemoveFromDatabase(sqlHandler.DatabaseConnection, currentID);
        }
    }
}
