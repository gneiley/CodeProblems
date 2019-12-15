using System;
using CSharpProblems.Utilities;

namespace CSharpProblems.Functions
{
    public class Maskify : BaseClass
    {
        public static void RunMaskifyNumbers()
        {
            while (KeepGoing == "yes")
            {
                Console.WriteLine("This program will help you mask strings longer than 4 chars");
                Console.WriteLine("Please type the string you would like to mask, then press enter.");
                string inputString = Console.ReadLine();

                Console.WriteLine(MaskifyNumbers(inputString));

                Console.WriteLine("Would you like to mask another string?");
                KeepGoing = Console.ReadLine();
                KeepGoing.ToLower();

                NavigatorUtility.Navigate();
            }
        }

        public static string MaskifyNumbers(string inputNumber)
        {
            char[] inputNumberArray = inputNumber.ToCharArray();
            char[] maskedArray = new char[inputNumber.Length];

            if (inputNumber.Length < 5)
            {
                return inputNumber;
            }
            for (int i = 0; i <= inputNumber.Length - 1; i++)
            {
                if (i <= inputNumber.Length - 5)
                {
                    maskedArray[i] = '#';
                }
                else
                {
                    maskedArray[i] = inputNumberArray[i];
                }
            }
            return new string(maskedArray);
        }
    }
}