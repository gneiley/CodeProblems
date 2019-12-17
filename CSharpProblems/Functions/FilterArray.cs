using System;
using System.Collections.Generic;
using CSharpProblems.Utilities;

namespace CSharpProblems.Functions
{
    public class FilterArray : BaseClass
    {
        private static readonly string numbers = "Numbers";
        private static readonly string noNumbers = "No Numbers";

        public static void RunFilterArray()
        {
            while (KeepGoing == "yes")
            { 
                string filterString = null;

                Console.WriteLine("Please enter the list of words, letters, numbers, \n" +
                    "or special characters you'd like to filder, separated by a comma.");
                string input = Console.ReadLine();

                bool filterCheck = true;

                Console.WriteLine($"If you would like to see all the numbers from the string, type '{numbers}', then enter.\n" +
                    $" Otherwise, type '{noNumbers}', then enter to see everything else.");

                while (filterCheck)
                {
                    filterString = Console.ReadLine().ToLower();

                    if (filterString == numbers.ToLower()
                        || filterString == noNumbers.ToLower())
                    {
                        filterCheck = false;
                    }
                    else
                    {
                        Console.WriteLine($"I'm sorry, that is not a valid command. Please type either '{numbers}' or " +
                            $"'{noNumbers}',\n" +
                            $"then press 'Enter'.");
                    }
                }

                Console.WriteLine(FilterOutLettersAndWords(input, filterString));
                NavigatorUtility.Navigate();
            }
        }

      
        public static string FilterOutLettersAndWords(string input, string filterString)
        {            
            string[] wordsAndNumbers = input.Split(',');
            List<int> justNumbers = new List<int>();
            List<string> justWords = new List<string>();

            foreach(string item in wordsAndNumbers)
            {
                string trimmedString = item.Trim();
                int integer = 0;
                bool isInt = Int32.TryParse(trimmedString, out integer);

                if(isInt == true)
                {
                    justNumbers.Add(integer);
                }
                else
                {
                    justWords.Add(trimmedString);
                }
            }

            string returnString = filterString == numbers.ToLower() ? string.Join(", ", justNumbers) :
                string.Join(", ", justWords);

            return returnString;
        }

    }
}