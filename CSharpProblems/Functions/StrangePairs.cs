using System;
using CSharpProblems.Utilities;

namespace CSharpProblems.Functions
{
    public class StrangePairs : BaseClass
    {
        public static void RunIsStrangeStringPair()
        {
            
            while (KeepGoing == "yes")
            {
                Console.WriteLine("This program will help you find strange string pairs!");
                Console.WriteLine("What is the first word?");
                string firstString = Console.ReadLine();
                Console.WriteLine("What is the second word");
                string secondString = Console.ReadLine();

                Console.WriteLine(IsStrangeStringPair(firstString, secondString));

                Console.WriteLine("Do you have more words to compare?");
                KeepGoing = Console.ReadLine();
                KeepGoing.ToLower();

                NavigatorUtility.Navigate();
            }
        }

        public static bool IsStrangeStringPair(string firstString, string secondString)
        {
            int stringOneLastLetterIndex = firstString.Length - 1;
            int stringTwoLastLetterInxex = secondString.Length - 1;

            char[] firstStringArray = firstString.ToCharArray();
            char[] secondStringArray = secondString.ToCharArray();

            if (string.IsNullOrEmpty(firstString) || string.IsNullOrEmpty(secondString))
            {
                return false;
            }

            if (char.ToLower(firstStringArray[0]) == char.ToLower(secondStringArray[stringTwoLastLetterInxex]))
            {
                return true;
            }

            if (char.ToLower(secondStringArray[0]) == char.ToLower(firstStringArray[stringOneLastLetterIndex]))
            {
                return true;
            }

            return false;
        }
    }
}