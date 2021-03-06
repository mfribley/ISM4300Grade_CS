﻿/* 
   Author: Mikessa Fribley
   Date: 1/21/2019
   Comments: This C# Console application code demonstrates the use of
             a conditional statement after getting input from users.
*/

using System;

namespace ISM4300Grade_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for input.
            Console.Write("What grade do you wish to earn in ISM 4300? ");

            /* 
               The try catch block will validate user input.
               If an user provides bad input, the catch block
               will handle the error and a message will be displayed.
            */
            try
            {
                // This variable will gather data from user input.
                string Input = Console.ReadLine();

                /* 
                   This variable will be used to store the grade 
                   after the input variable is parsed to integer.
                */
                int Grade = int.Parse(Input);

                /* 
                   This IF/ELSE IF/ELSE statement is used to conditionally
                   test the users input. Various letter grades are available
                   depending on the integer grade entered by the user.
                */
                if (Grade >= 98 && Grade <= 100)
                {
                    Console.WriteLine("You are striving for an A+");
                    Console.WriteLine("Press any key to exit.");
                    Console.ReadKey(true);
                }

                else if (Grade >= 92 && Grade <= 97)
                {
                    Console.WriteLine("You are striving for an A");
                    Console.WriteLine("Press any key to exit.");
                    Console.ReadKey(true);
                }

                else if (Grade >= 90 && Grade <= 91)
                {
                    Console.WriteLine("You are striving for an A-");
                    Console.WriteLine("Press any key to exit.");
                    Console.ReadKey(true);
                }

                else if (Grade >= 88 && Grade <= 89)
                {
                    Console.WriteLine("You are striving for a B+");
                    Console.WriteLine("Press any key to exit.");
                    Console.ReadKey(true);
                }

                else if (Grade >= 82 && Grade <= 87)
                {
                    Console.WriteLine("You are striving for a B");
                    Console.WriteLine("Press any key to exit.");
                    Console.ReadKey(true);
                }

                else if (Grade >= 80 && Grade <= 81)
                {
                    Console.WriteLine("You are striving for a B-");
                    Console.WriteLine("Press any key to exit.");
                    Console.ReadKey(true);
                }

                else if (Grade >= 78 && Grade <= 79)
                {
                    Console.WriteLine("You are striving for a C+");
                    Console.WriteLine("Press any key to exit.");
                    Console.ReadKey(true);
                }

                else if (Grade >= 72 && Grade <= 77)
                {
                    Console.WriteLine("You are striving for a C");
                    Console.WriteLine("Press any key to exit.");
                    Console.ReadKey(true);
                }

                else if (Grade >= 70 && Grade <= 71)
                {
                    Console.WriteLine("You are striving for a C-");
                    Console.WriteLine("Press any key to exit.");
                    Console.ReadKey(true);
                }

                else if (Grade >= 68 && Grade <= 69)
                {
                    Console.WriteLine("You are striving for a D+");
                    Console.WriteLine("Press any key to exit.");
                    Console.ReadKey(true);
                }

                else if (Grade >= 62 && Grade <= 67)
                {
                    Console.WriteLine("You are striving for a D");
                    Console.WriteLine("Press any key to exit.");
                    Console.ReadKey(true);
                }

                else if (Grade >= 60 && Grade <= 61)
                {
                    Console.WriteLine("You are striving for a D-");
                    Console.WriteLine("Press any key to exit.");
                    Console.ReadKey(true);
                }

                else if (Grade >= 0 && Grade < 60)
                {
                    Console.WriteLine("You are striving for a F");
                    Console.WriteLine("Press any key to exit.");
                    Console.ReadKey(true);
                }

                else
                {
                    Console.WriteLine("Enter an integer between 0 and 100 next time.");
                    Console.WriteLine("Press any key to exit the application.");
                    Console.ReadKey(true);
                }
            } // End of try.

            catch
            {
                Console.WriteLine("Please use an integer data type next time.");
                Console.WriteLine("Press any key to exit the application.");
                Console.ReadKey(true);
            } // End of catch.
        } // End of main.
    } // End of class.
} // End of namespace.
