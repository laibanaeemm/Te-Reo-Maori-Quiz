using System;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * Display intro.
             * Declare all the variables needed for this program.
             * Use Console.Clear in order to make program more neater.
             * Start level 1.
             * Ask user all the questions.
             * When questioned get answered, convert "ans" to "char".
             * Repeat the same process for the questions in Level 2 and 3.
            */

            char choice;

            do
            {
                Console.WriteLine("Te Reo Maori Quiz!\n"); // display intro

                Console.WriteLine("- This quiz will test you on how well you know Te Reo Maori.");
                Console.WriteLine("- The quiz will be seperated in 3 levels, with each level quizing you on a different topic in Maori.");
                Console.WriteLine("- One more thing that you must remember is to have fun!");
                Console.WriteLine("- Let's get started!\n");
                Console.WriteLine("Press the enter key to start this quiz");
                Console.ReadLine(); //prompting the user to press enter
                Console.Clear(); // clears the program to be able to make it look neater

                Console.WriteLine("Level 1: Colours");
                Console.WriteLine("Press enter to start the first level");
                Console.ReadLine();
                Console.Clear();

                char ans;
                int score1 = 0;

                


                Console.WriteLine("Question 1: How do you say brown in Maori?");
                Console.WriteLine("A. Waiporoporo");
                Console.WriteLine("B. Whero");
                Console.WriteLine("C. Kowhai");
                Console.WriteLine("D. Paraone");
                ans = Convert.ToChar(Console.ReadLine()); //this tells the user to press enter to submit their answer to the computer, while converting ans to char;

                while (ans != 'a' && ans != 'b' && ans != 'c' && ans != 'd' && ans != 'A' && ans != 'B' && ans != 'C' && ans != 'D')
                {
                    Console.WriteLine("Please select only a, b, c or d");
                    ans = Convert.ToChar(Console.ReadLine());
                }
                if (ans == 'D' || ans == 'd')
                {
                    Console.WriteLine("Correct!");
                    score1 = score1 + 1; // stores 1 point in the variable 'score1'

                }
                else
                {
                    Console.WriteLine("Wrong!");
                }


                Console.WriteLine("\nQuestion 2: How do you say black in Maori?");
                Console.WriteLine("A. Ma");
                Console.WriteLine("B. Mangu");
                Console.WriteLine("C. Kakariki");
                Console.WriteLine("D. Karikiuri");
                ans = Convert.ToChar(Console.ReadLine());
                while (ans != 'a' && ans != 'b' && ans != 'c' && ans != 'd' && ans != 'A' && ans != 'B' && ans != 'C' && ans != 'D')
                {
                    Console.WriteLine("Please select only a, b, c or d");
                    ans = Convert.ToChar(Console.ReadLine());
                }
                if (ans == 'B' || ans == 'b')
                {
                    Console.WriteLine("Correct!");
                    score1 = score1 + 1;

                }
                else
                {
                    Console.WriteLine("Wrong!");
                }


                Console.WriteLine("\nQuestion 3: How do you say purple in Maori");
                Console.WriteLine("A. Waiporoporo");
                Console.WriteLine("B. Karerarera");
                Console.WriteLine("C. Mawhero");
                Console.WriteLine("D. Whero");
                ans = Convert.ToChar(Console.ReadLine());
                while (ans != 'a' && ans != 'b' && ans != 'c' && ans != 'd' && ans != 'A' && ans != 'B' && ans != 'C' && ans != 'D')
                {
                    Console.WriteLine("Please select only a, b, c or d");
                    ans = Convert.ToChar(Console.ReadLine());
                }
                if (ans == 'A' || ans == 'a')
                {
                    Console.WriteLine("Correct!");
                    score1 = score1 + 1;

                }
                else
                {
                    Console.WriteLine("Wrong!");
                }

                Console.WriteLine("\nQuestion 4: How do you say light green in Maori?");
                Console.WriteLine("A. Mawhero");
                Console.WriteLine("B. Kiwikiwi");
                Console.WriteLine("C. Karerarera");
                Console.WriteLine("D. Pango");
                ans = Convert.ToChar(Console.ReadLine());
                while (ans != 'a' && ans != 'b' && ans != 'c' && ans != 'd' && ans != 'A' && ans != 'B' && ans != 'C' && ans != 'D')
                {
                    Console.WriteLine("Please select only a, b, c or d");
                    ans = Convert.ToChar(Console.ReadLine());
                }
                if (ans == 'C' || ans == 'c')
                {
                    Console.WriteLine("Correct!");
                    score1 = score1 + 1;

                }
                else
                {
                    Console.WriteLine("Wrong!");
                }


                Console.WriteLine("\nQuestion 5: How do you say pink in Maori");
                Console.WriteLine("A. Orangitea");
                Console.WriteLine("B. Mawhero");
                Console.WriteLine("C. Kowhai");
                Console.WriteLine("D. Paraone");
                ans = Convert.ToChar(Console.ReadLine());
                while (ans != 'a' && ans != 'b' && ans != 'c' && ans != 'd' && ans != 'A' && ans != 'B' && ans != 'C' && ans != 'D')
                {
                    Console.WriteLine("Please select only a, b, c or d");
                    ans = Convert.ToChar(Console.ReadLine());
                }
                if (ans == 'B' || ans == 'b')
                {
                    Console.WriteLine("Correct!");
                    score1 = score1 + 1;

                }
                else
                {
                    Console.WriteLine("Wrong!");
                }



                Console.WriteLine("\nQuestion 6: How do you say light blue in Maori?");
                Console.WriteLine("A. Makurakura");
                Console.WriteLine("B. Whero");
                Console.WriteLine("C. Orangitea");
                Console.WriteLine("D. Paraone");
                ans = Convert.ToChar(Console.ReadLine());
                while (ans != 'a' && ans != 'b' && ans != 'c' && ans != 'd' && ans != 'A' && ans != 'B' && ans != 'C' && ans != 'D')
                {
                    Console.WriteLine("Please select only a, b, c or d");
                    ans = Convert.ToChar(Console.ReadLine());
                }
                if (ans == 'C' || ans == 'c')
                {
                    Console.WriteLine("Correct!");
                    score1 = score1 + 1;

                }
                else
                {
                    Console.WriteLine("Wrong!");
                }

                Console.WriteLine("\nQuestion 7: How do you say grey in Maori?");
                Console.WriteLine("A. Karaka");
                Console.WriteLine("B. Waiporoporo");
                Console.WriteLine("C. Kowhai");
                Console.WriteLine("D. Kiwikiwi");
                ans = Convert.ToChar(Console.ReadLine());
                while (ans != 'a' && ans != 'b' && ans != 'c' && ans != 'd' && ans != 'A' && ans != 'B' && ans != 'C' && ans != 'D')
                {
                    Console.WriteLine("Please select only a, b, c or d");
                    ans = Convert.ToChar(Console.ReadLine());
                }
                if (ans == 'D' || ans == 'd')
                {
                    Console.WriteLine("Correct!");
                    score1 = score1 + 1;

                }
                else
                {
                    Console.WriteLine("Wrong!");
                }

                Console.WriteLine("\nQuestion 8: How do you say yellow in Maori?");
                Console.WriteLine("A. Karikiuri");
                Console.WriteLine("B. Whero");
                Console.WriteLine("C. Kowhai");
                Console.WriteLine("D. Paraone");
                ans = Convert.ToChar(Console.ReadLine());
                while (ans != 'a' && ans != 'b' && ans != 'c' && ans != 'd' && ans != 'A' && ans != 'B' && ans != 'C' && ans != 'D')
                {
                    Console.WriteLine("Please select only a, b, c or d");
                    ans = Convert.ToChar(Console.ReadLine());
                }
                if (ans == 'C' || ans == 'c')
                {
                    Console.WriteLine("Correct!");
                    score1 = score1 + 1;

                }
                else
                {
                    Console.WriteLine("Wrong!");
                }

                Console.WriteLine("\nQuestion 9: How do you say magenta in Maori?");
                Console.WriteLine("A. Makurakura");
                Console.WriteLine("B. Whero");
                Console.WriteLine("C. Kowhai");
                Console.WriteLine("D. Paraone");
                ans = Convert.ToChar(Console.ReadLine());
                while (ans != 'a' && ans != 'b' && ans != 'c' && ans != 'd' && ans != 'A' && ans != 'B' && ans != 'C' && ans != 'D')
                {
                    Console.WriteLine("Please select only a, b, c or d");
                    ans = Convert.ToChar(Console.ReadLine());
                }
                if (ans == 'A' || ans == 'a')
                {
                    Console.WriteLine("Correct!");
                    score1 = score1 + 1;

                }
                else
                {
                    Console.WriteLine("Wrong!");
                }

                Console.WriteLine("\nQuestion 10: How do you say red in Maori?");
                Console.WriteLine("A. Karerarera");
                Console.WriteLine("B. Whero");
                Console.WriteLine("C. Mangu");
                Console.WriteLine("D. Paraone");
                ans = Convert.ToChar(Console.ReadLine());
                while (ans != 'a' && ans != 'b' && ans != 'c' && ans != 'd' && ans != 'A' && ans != 'B' && ans != 'C' && ans != 'D')
                {
                    Console.WriteLine("Please select only a, b, c or d");
                    ans = Convert.ToChar(Console.ReadLine());
                }
                if (ans == 'B' || ans == 'b')
                {
                    Console.WriteLine("Correct!");
                    score1 = score1 + 1;

                }
                else
                {
                    Console.WriteLine("Wrong!");
                }


                Console.WriteLine("Your score on Level 1 is: " + score1);
                Console.WriteLine("Press enter to go on to the next level");
                Console.ReadLine();
                Console.Clear();

                int score2 = 0;

                Console.WriteLine("Level 2: Animals");
                Console.WriteLine("Press enter to get started");
                Console.ReadLine();
                Console.Clear();

                Console.WriteLine("Question 1: How do you say horse in Maori?");
                Console.WriteLine("A. Hoiho");
                Console.WriteLine("B. Kuri");
                Console.WriteLine("C. Ngeru");
                Console.WriteLine("D. Tia");
                ans = Convert.ToChar(Console.ReadLine());
                while (ans != 'a' && ans != 'b' && ans != 'c' && ans != 'd' && ans != 'A' && ans != 'B' && ans != 'C' && ans != 'D')
                {
                    Console.WriteLine("Please select only a, b, c or d");
                    ans = Convert.ToChar(Console.ReadLine());
                }
                if (ans == 'A' || ans == 'a')
                {
                    Console.WriteLine("Correct!");
                    score2 = score2 + 1;

                }
                else
                {
                    Console.WriteLine("Wrong!");
                }


                Console.WriteLine("\nQuestion 2: How do you say goat in Maori?");
                Console.WriteLine("A. Hoiho");
                Console.WriteLine("B. Nanenane");
                Console.WriteLine("C. Ngeru");
                Console.WriteLine("D. Heihei");
                ans = Convert.ToChar(Console.ReadLine());
                while (ans != 'a' && ans != 'b' && ans != 'c' && ans != 'd' && ans != 'A' && ans != 'B' && ans != 'C' && ans != 'D')
                {
                    Console.WriteLine("Please select only a, b, c or d");
                    ans = Convert.ToChar(Console.ReadLine());
                }
                if (ans == 'B' || ans == 'b')
                {
                    Console.WriteLine("Correct!");
                    score2 = score2 + 1;

                }
                else
                {
                    Console.WriteLine("Wrong!");
                }

                Console.WriteLine("\nQuestion 3: How do you say dog in Maori?");
                Console.WriteLine("A. Hoiho");
                Console.WriteLine("B.Ngeru");
                Console.WriteLine("C. Kuri");
                Console.WriteLine("D. Tia");
                ans = Convert.ToChar(Console.ReadLine());
                while (ans != 'a' && ans != 'b' && ans != 'c' && ans != 'd' && ans != 'A' && ans != 'B' && ans != 'C' && ans != 'D')
                {
                    Console.WriteLine("Please select only a, b, c or d");
                    ans = Convert.ToChar(Console.ReadLine());
                }
                if (ans == 'C' || ans == 'c')
                {
                    Console.WriteLine("Correct!");
                    score2 = score2 + 1;

                }
                else
                {
                    Console.WriteLine("Wrong!");
                }

                Console.WriteLine("\nQuestion 4: How do you say cat in Maori? ");
                Console.WriteLine("A. Heihei");
                Console.WriteLine("B.Ngeru");
                Console.WriteLine("C. Kuri");
                Console.WriteLine("D. Tia");
                ans = Convert.ToChar(Console.ReadLine());
                while (ans != 'a' && ans != 'b' && ans != 'c' && ans != 'd' && ans != 'A' && ans != 'B' && ans != 'C' && ans != 'D')
                {
                    Console.WriteLine("Please select only a, b, c or d");
                    ans = Convert.ToChar(Console.ReadLine());
                }
                if (ans == 'B' || ans == 'b')
                {
                    Console.WriteLine("Correct!");
                    score2 = score2 + 1;

                }
                else
                {
                    Console.WriteLine("Wrong!");
                }


                Console.WriteLine("\nQuestion 5: How do you say hen in Maori");
                Console.WriteLine("A. Rapeti");
                Console.WriteLine("B.Ngeru");
                Console.WriteLine("C. Kuri");
                Console.WriteLine("D. Heihei");
                ans = Convert.ToChar(Console.ReadLine());
                while (ans != 'a' && ans != 'b' && ans != 'c' && ans != 'd' && ans != 'A' && ans != 'B' && ans != 'C' && ans != 'D')
                {
                    Console.WriteLine("Please select only a, b, c or d");
                    ans = Convert.ToChar(Console.ReadLine());
                }
                if (ans == 'D' || ans == 'd')
                {
                    Console.WriteLine("Correct!");
                    score2 = score2 + 1;

                }
                else
                {
                    Console.WriteLine("Wrong!");
                }

                Console.WriteLine("\nQuestion 6: How do you say rabbit in Maori?");
                Console.WriteLine("A. Rapeti");
                Console.WriteLine("B.Ngeru");
                Console.WriteLine("C. Kuri");
                Console.WriteLine("D. Tia");
                ans = Convert.ToChar(Console.ReadLine());
                while (ans != 'a' && ans != 'b' && ans != 'c' && ans != 'd' && ans != 'A' && ans != 'B' && ans != 'C' && ans != 'D')
                {
                    Console.WriteLine("Please select only a, b, c or d");
                    ans = Convert.ToChar(Console.ReadLine());
                }
                if (ans == 'A' || ans == 'a')
                {
                    Console.WriteLine("Correct!");
                    score2 = score2 + 1;

                }
                else
                {
                    Console.WriteLine("Wrong!");
                }

                Console.WriteLine("\nQuestion 7: How do you say deer in Maori?");
                Console.WriteLine("A. Hoiho");
                Console.WriteLine("B.Hipi");
                Console.WriteLine("C. Kuri");
                Console.WriteLine("D. Tia");
                ans = Convert.ToChar(Console.ReadLine());
                while (ans != 'a' && ans != 'b' && ans != 'c' && ans != 'd' && ans != 'A' && ans != 'B' && ans != 'C' && ans != 'D')
                {
                    Console.WriteLine("Please select only a, b, c or d");
                    ans = Convert.ToChar(Console.ReadLine());
                }
                if (ans == 'D' || ans == 'd')
                {
                    Console.WriteLine("Correct!");
                    score2 = score2 + 1;

                }
                else
                {
                    Console.WriteLine("Wrong!");
                }


                Console.WriteLine("\n Question 8: How do you say sheep in Maori?");
                Console.WriteLine("A. Hoiho");
                Console.WriteLine("B. Hipi ");
                Console.WriteLine("C. Kuri");
                Console.WriteLine("D. Tia");
                ans = Convert.ToChar(Console.ReadLine());
                while (ans != 'a' && ans != 'b' && ans != 'c' && ans != 'd' && ans != 'A' && ans != 'B' && ans != 'C' && ans != 'D')
                {
                    Console.WriteLine("Please select only a, b, c or d");
                    ans = Convert.ToChar(Console.ReadLine());
                }
                if (ans == 'B' || ans == 'b')
                {
                    Console.WriteLine("Correct!");
                    score2 = score2 + 1;

                }
                else
                {
                    Console.WriteLine("Wrong!");
                }


                Console.WriteLine("\nQuestion 9: How do you say possum in Maori?");
                Console.WriteLine("A. Paihamu");
                Console.WriteLine("B.Ngeru");
                Console.WriteLine("C. Hipi");
                Console.WriteLine("D. Tia");
                ans = Convert.ToChar(Console.ReadLine());
                while (ans != 'a' && ans != 'b' && ans != 'c' && ans != 'd' && ans != 'A' && ans != 'B' && ans != 'C' && ans != 'D')
                {
                    Console.WriteLine("Please select only a, b, c or d");
                    ans = Convert.ToChar(Console.ReadLine());
                }
                if (ans == 'A' || ans == 'a')
                {
                    Console.WriteLine("Correct!");
                    score2 = score2 + 1;

                }
                else
                {
                    Console.WriteLine("Wrong!");
                }


                Console.WriteLine("\nQuestion 10: How do you say pig in Maori?");
                Console.WriteLine("A. Paihamu");
                Console.WriteLine("B.Poaka");
                Console.WriteLine("C. Hipi");
                Console.WriteLine("D. Tia");
                ans = Convert.ToChar(Console.ReadLine());
                while (ans != 'a' && ans != 'b' && ans != 'c' && ans != 'd' && ans != 'A' && ans != 'B' && ans != 'C' && ans != 'D')
                {
                    Console.WriteLine("Please select only a, b, c or d");
                    ans = Convert.ToChar(Console.ReadLine());
                }
                if (ans == 'B' || ans == 'b')
                {
                    Console.WriteLine("Correct!");
                    score2 = score2 + 1;

                }
                else
                {
                    Console.WriteLine("Wrong!");
                }

                Console.WriteLine("Your score on Level 2 is: " + score2);
                Console.WriteLine("Press enter to get started");
                Console.ReadLine();
                Console.Clear();



                Console.WriteLine("Level 3: Fruit");
                Console.WriteLine("Press enter to get started");
                Console.ReadLine();
                Console.Clear();

                int score3 = 0;

                Console.WriteLine("\nQuestion 1: How do you say apple in Maori");
                Console.WriteLine("A. Panana");
                Console.WriteLine("B. Aporo");
                Console.WriteLine("C. Manarini");
                Console.WriteLine("D. Remana");
                ans = Convert.ToChar(Console.ReadLine());
                while (ans != 'a' && ans != 'b' && ans != 'c' && ans != 'd' && ans != 'A' && ans != 'B' && ans != 'C' && ans != 'D')
                {
                    Console.WriteLine("Please select only a, b, c or d");
                    ans = Convert.ToChar(Console.ReadLine());
                }
                if (ans == 'B' || ans == 'b')
                {
                    Console.WriteLine("Correct!");
                    score3 = score3 + 1;

                }
                else
                {
                    Console.WriteLine("Wrong!");
                }

                Console.WriteLine("\nQuestion 2: How do you say orange in Maori");
                Console.WriteLine("A. Panana");
                Console.WriteLine("B. Arani");
                Console.WriteLine("C. Manarini");
                Console.WriteLine("D. Remana");
                ans = Convert.ToChar(Console.ReadLine());
                while (ans != 'a' && ans != 'b' && ans != 'c' && ans != 'd' && ans != 'A' && ans != 'B' && ans != 'C' && ans != 'D')
                {
                    Console.WriteLine("Please select only a, b, c or d");
                    ans = Convert.ToChar(Console.ReadLine());
                }
                if (ans == 'B' || ans == 'b')
                {
                    Console.WriteLine("Correct!");
                    score3 = score3 + 1;

                }
                else
                {
                    Console.WriteLine("Wrong!");
                }

                Console.WriteLine("\nQuestion 3: How do you say banana in Maori");
                Console.WriteLine("A. Panana");
                Console.WriteLine("B. Aporo");
                Console.WriteLine("C. Manarini");
                Console.WriteLine("D. Remana");
                ans = Convert.ToChar(Console.ReadLine());
                while (ans != 'a' && ans != 'b' && ans != 'c' && ans != 'd' && ans != 'A' && ans != 'B' && ans != 'C' && ans != 'D')
                {
                    Console.WriteLine("Please select only a, b, c or d");
                    ans = Convert.ToChar(Console.ReadLine());
                }
                if (ans == 'A' || ans == 'a')
                {
                    Console.WriteLine("Correct!");
                    score3 = score3 + 1;

                }
                else
                {
                    Console.WriteLine("Wrong!");
                }

                Console.WriteLine("\nQuestion 4: How do you say mandarin in Maori");
                Console.WriteLine("A. Rahopuru");
                Console.WriteLine("B. Aporo");
                Console.WriteLine("C. Manarini");
                Console.WriteLine("D. Remana");
                ans = Convert.ToChar(Console.ReadLine());
                while (ans != 'a' && ans != 'b' && ans != 'c' && ans != 'd' && ans != 'A' && ans != 'B' && ans != 'C' && ans != 'D')
                {
                    Console.WriteLine("Please select only a, b, c or d");
                    ans = Convert.ToChar(Console.ReadLine());
                }
                if (ans == 'C' || ans == 'c')
                {
                    Console.WriteLine("Correct!");
                    score3 = score3 + 1;

                }
                else
                {
                    Console.WriteLine("Wrong!");
                }

                Console.WriteLine("\nQuestion 5: How do you say peach in Maori");
                Console.WriteLine("A. Panana");
                Console.WriteLine("B. Aporo");
                Console.WriteLine("C. Manarini");
                Console.WriteLine("D. Pititi");
                ans = Convert.ToChar(Console.ReadLine());
                while (ans != 'a' && ans != 'b' && ans != 'c' && ans != 'd' && ans != 'A' && ans != 'B' && ans != 'C' && ans != 'D')
                {
                    Console.WriteLine("Please select only a, b, c or d");
                    ans = Convert.ToChar(Console.ReadLine());
                }
                if (ans == 'D' || ans == 'd')
                {
                    Console.WriteLine("Correct!");
                    score2 = score2 + 1;

                }
                else
                {
                    Console.WriteLine("Wrong!");
                }

                Console.WriteLine("\nQuestion 6: How do you say avocado in Maori");
                Console.WriteLine("A. Panana");
                Console.WriteLine("B. Aporo");
                Console.WriteLine("C. Rahopuru");
                Console.WriteLine("D. Remana");
                ans = Convert.ToChar(Console.ReadLine());
                while (ans != 'a' && ans != 'b' && ans != 'c' && ans != 'd' && ans != 'A' && ans != 'B' && ans != 'C' && ans != 'D')
                {
                    Console.WriteLine("Please select only a, b, c or d");
                    ans = Convert.ToChar(Console.ReadLine());
                }
                if (ans == 'C' || ans == 'c')
                {
                    Console.WriteLine("Correct!");
                    score3 = score3 + 1;

                }
                else
                {
                    Console.WriteLine("Wrong!");
                }

                Console.WriteLine("\nQuestion 7: How do you say lemon in Maori");
                Console.WriteLine("A. Panana");
                Console.WriteLine("B. Aporo");
                Console.WriteLine("C. Manarini");
                Console.WriteLine("D. Remana");
                ans = Convert.ToChar(Console.ReadLine());
                while (ans != 'a' && ans != 'b' && ans != 'c' && ans != 'd' && ans != 'A' && ans != 'B' && ans != 'C' && ans != 'D')
                {
                    Console.WriteLine("Please select only a, b, c or d");
                    ans = Convert.ToChar(Console.ReadLine());
                }
                if (ans == 'D' || ans == 'd')
                {
                    Console.WriteLine("Correct!");
                    score3 = score3 + 1;

                }
                else
                {
                    Console.WriteLine("Wrong!");
                }

                Console.WriteLine("\nQuestion 8: How do you say strawberry in Maori");
                Console.WriteLine("A. Panana");
                Console.WriteLine("B. Ropere");
                Console.WriteLine("C. Manarini");
                Console.WriteLine("D. Remana");
                ans = Convert.ToChar(Console.ReadLine());
                while (ans != 'a' && ans != 'b' && ans != 'c' && ans != 'd' && ans != 'A' && ans != 'B' && ans != 'C' && ans != 'D')
                {
                    Console.WriteLine("Please select only a, b, c or d");
                    ans = Convert.ToChar(Console.ReadLine());
                }
                if (ans == 'B' || ans == 'b')
                {
                    Console.WriteLine("Correct!");
                    score3 = score3 + 1;

                }
                else
                {
                    Console.WriteLine("Wrong!");
                }

                Console.WriteLine("\nQuestion 9: How do you say pear in Maori");
                Console.WriteLine("A. Pea");
                Console.WriteLine("B. Aporo");
                Console.WriteLine("C. Manarini");
                Console.WriteLine("D. Remana");
                ans = Convert.ToChar(Console.ReadLine());
                while (ans != 'a' && ans != 'b' && ans != 'c' && ans != 'd' && ans != 'A' && ans != 'B' && ans != 'C' && ans != 'D')
                {
                    Console.WriteLine("Please select only a, b, c or d");
                    ans = Convert.ToChar(Console.ReadLine());
                }
                if (ans == 'A' || ans == 'a')
                {
                    Console.WriteLine("Correct!");
                    score3 = score3 + 1;

                }
                else
                {
                    Console.WriteLine("Wrong!");
                }

                Console.WriteLine("\nQuestion 10: How do you say grapes in Maori");
                Console.WriteLine("A. Pea");
                Console.WriteLine("B. Aporo");
                Console.WriteLine("C. Rapere");
                Console.WriteLine("D. Remana");
                ans = Convert.ToChar(Console.ReadLine());
                while (ans != 'a' && ans != 'b' && ans != 'c' && ans != 'd' && ans != 'A' && ans != 'B' && ans != 'C' && ans != 'D')
                {
                    Console.WriteLine("Please select only a, b, c or d");
                    ans = Convert.ToChar(Console.ReadLine());
                }
                if (ans == 'C' || ans == 'c')
                {
                    Console.WriteLine("Correct!");
                    score3 = score3 + 1;

                }
                else
                {
                    Console.WriteLine("Wrong!");
                }

                Console.WriteLine("Your score on Level 3 is: " + score3);
                Console.WriteLine("Press enter");
                Console.ReadLine();
                Console.Clear();

                int ovscore;
                //with this variable, it saves the users overall score by adding them all together;
                Console.WriteLine("Congratulations! You have finshed all three levels successfully!");
                Console.WriteLine("Your overall score from all three levels are: ");
                ovscore = score1 + score2 + score3;
                Console.WriteLine(ovscore);

                Console.WriteLine("I hope you had learned something from this and feel free to do this quiz as many times as you like");
                Console.WriteLine("Goodbye");
                Console.WriteLine("Press enter to end the quiz or if you want to do it again, please press 'y'");
                choice = Convert.ToChar(Console.ReadLine());
                Console.Clear();


            } while (choice == 'y' || choice == 'Y');

        }
    }
}
