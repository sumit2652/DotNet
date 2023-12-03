using System;

namespace Switch_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            bool isValidInput = false;

            do
            {
                Console.WriteLine("What is your age?");
                string ageString = Console.ReadLine();

                if (int.TryParse(ageString, out age))
                {
                    isValidInput = true; // Break out of the loop if the input is valid
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid age as a number.");
                }

            } while (!isValidInput);

            switch (age)
            {
                case 15:
                    Console.WriteLine("Too young for a party in the club");
                    break;
                case 25:
                    Console.WriteLine("You can join the club");
                    break;
                default:
                    Console.WriteLine("You are neither 15 nor 25. How old are you?");
                    break;
            }

            Console.Read();
        }
    }
}
