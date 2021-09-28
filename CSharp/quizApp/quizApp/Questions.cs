using System;
using System.Collections.Generic;

namespace quizApp
{
    public class Questions
    {
        private int index = 0;
        private string curQuestion;
        private string curAnswer;
        private List<string> curPosAnswers;
        private bool check = false;

        public bool ReadQuestions(string quest, string answer, List<string> posAnswers)
        {
            curQuestion = quest;
            curAnswer = answer;
            curPosAnswers = posAnswers;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(curQuestion);
            Console.ForegroundColor = ConsoleColor.White;

            Console.CursorVisible = false;
            while (true)
            {
                string questionAnswerItems = QuestionScrollFunctionality(curPosAnswers);
                if (questionAnswerItems == " " + curAnswer && check)
                {
                    Console.Clear();

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(" \n Correct!\n");
                    Console.ResetColor();
                    // returns false to exit while loop
                    return false;
                }
                else if (questionAnswerItems != " " + curAnswer)
                {
                    Console.Clear();

                    if (check)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(" \n Wrong answer");
                        Console.Write(" \n Select another choice, then press enter\n\n");
                    }
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(curQuestion);
                    Console.ResetColor();
                }
            }
        }

        public void YouWon()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("    You Won");
        }

        /// <summary>
        /// Creates scrolling effect
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public string QuestionScrollFunctionality(List<string> items)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (i == index)
                {
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.ForegroundColor = ConsoleColor.Yellow;

                    Console.WriteLine(items[i]);
                }
                else
                {
                    Console.WriteLine(items[i]);
                }
                Console.ResetColor();
            }

            ConsoleKeyInfo ckey = Console.ReadKey();

            if (ckey.Key == ConsoleKey.DownArrow)
            {
                check = false;
                if (index == items.Count - 1)
                {
                    //index = 0; //Remove the comment to return to the topmost item in the list
                }
                else { index++; }
            }
            else if (ckey.Key == ConsoleKey.UpArrow)
            {
                check = false;
                if (index <= 0)
                {
                    //index = menuItem.Count - 1; //Remove the comment to return to the item in the bottom of the list
                }
                else { index--; }
            }
            else if (ckey.Key == ConsoleKey.Enter)
            {
                check = true;
                return items[index];
            }
            else
            {
                check = false;
                return "";
            }

            Console.Clear();
            return "";
        }

    }
}
