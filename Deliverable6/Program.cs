using System;

namespace Deliverable6
{
    class Program
    {
        static void Continue()
        {
            string userInputContinue = "";
            bool userContinue = true;

            Console.Write("Would you like to continue (y/n)? ");
            userInputContinue = Console.ReadLine().ToLower();

            if (userInputContinue == "y")
            {
                userContinue = true;
            }
            else
            {
                Console.WriteLine("Goodbye!");
                System.Environment.Exit(0);
            }
        }

        static void Main(string[] args)
        {
            int[] arrNumbers = { 2, 8, 0, 24, 51 };
            int userIndexInput = 0;
            bool userContinue = true;

            while (userContinue == true)
            {
                Console.Write("Enter an index of the array: ");
                if (int.TryParse(Console.ReadLine(), out userIndexInput))
                {
                    try
                    {
                        Console.WriteLine($"The value at index {userIndexInput} is {arrNumbers[userIndexInput]}");
                    }
                    catch (System.IndexOutOfRangeException)
                    {
                        Console.WriteLine("That is not a valid index.");
                    }
                }
                Continue();
            }

            // END OF EXERCISE 31

            //int[] arrNumbers = {2, 8, 0, 24, 51};
            //int userNumberInput = 0;
            //bool userContinue = true;

            //while (userContinue == true)
            //{
            //    Console.Write("Enter a number: ");
            //    if (int.TryParse(Console.ReadLine(), out userNumberInput))
            //    {
            //        int testNumberIndex = Array.IndexOf(arrNumbers, userNumberInput);

            //        if (testNumberIndex <= 0)
            //        {
            //            Console.WriteLine($"The value {userNumberInput} can be found at index {testNumberIndex}.");
            //        }
            //        else
            //        {
            //            Console.WriteLine("That value cannot be found in the array.");
            //        }

            //        Continue();
            //    }
            //}    
        }
    }
}
