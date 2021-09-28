using System;
using System.Collections.Generic;

namespace QuizLibrary
{
    
    public class Questions
    {
        private static int index = 0;
        private static bool check = false;

        public void QuestionOne()
        {
            string question = " 1. When was C# invented?\n";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(question);
            Console.ForegroundColor = ConsoleColor.White;

            List<string> possibleAnswers = new List<string>()
            {
                " 1983",
                " 2002",
                " 2000",
                " 1995",
                " 2012"

            };

            Console.CursorVisible = false;
            while (true)
            {
                string questionAnswerItems = QuestionScrollFunctionality(possibleAnswers);
                if (questionAnswerItems == " 2000" && check)
                {
                    Console.Clear();

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(" \n Correct!\n");
                    Console.ResetColor();
                    QuestionTwo();

                }
                else if (questionAnswerItems != " 2000")
                {
                    Console.Clear();

                    if (check)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(" \n Wrong answer");
                        Console.Write(" \n Select another choice, then press enter\n\n");
                    }
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(question);
                    Console.ResetColor();


                }

            }

        }

        public void QuestionTwo()
        {
            string question = " 2. Who invented C#?\n";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(question);
            Console.ForegroundColor = ConsoleColor.White;



            List<string> possibleAnswers = new List<string>()
            {
                " Anders Hejlsberg",
                " D. Luffy",
                " Linus Torvalds",
                " The Rock",
                " Bjarne Stroustrup"

            };

            Console.CursorVisible = false;
            while (true)
            {
                string questionAnswerItems = QuestionScrollFunctionality(possibleAnswers);
                if (questionAnswerItems == " Anders Hejlsberg" && check)
                {
                    Console.Clear();

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(" \n Correct!\n");
                    Console.ResetColor();
                    QuestionThree();
                }
                else if (questionAnswerItems != " Anders Hejlsberg")
                {
                    Console.Clear();

                    if (check)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(" \n Wrong answer");
                        Console.Write(" \n Select another choice, then press enter\n\n");
                    }
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(question);
                    Console.ResetColor();


                }

            }

        }

        public void QuestionThree()
        {
            string question = " 3. The dog doing?\n";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(question);
            Console.ForegroundColor = ConsoleColor.White;

            List<string> possibleAnswers = new List<string>()
            {
                " What the dog doin?",
                " Walking",
                " Eating",
                " Sleeping",
                " Nothing"

            };

            Console.CursorVisible = false;
            while (true)
            {
                string questionAnswerItems = QuestionScrollFunctionality(possibleAnswers);
                if (questionAnswerItems == " What the dog doin?" && check)
                {
                    Console.Clear();

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(" \n Correct!\n");
                    Console.ResetColor();
                    YouWon();
                }
                else if (questionAnswerItems != " What the dog doin?")
                {
                    Console.Clear();

                    if (check)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(" \n Wrong answer");
                        Console.Write(" \n Select another choice, then press enter\n\n");
                    }
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(question);
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
