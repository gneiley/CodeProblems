using System;

namespace CSharpProblems.Utilities
{
    public class NavigatorUtility : BaseClass
    {
        private static readonly string command = "Please type 'Yes' or 'No', and press 'Enter'.";
        public static void Navigate()
        {
            Console.WriteLine($"Run this operation again?\n {command}");
            KeepGoing = Console.ReadLine().ToLower();
            if (KeepGoing == "no")
            {
                Console.WriteLine($"Return to main menu?\n {command}");
                ReturnToMenu = Console.ReadLine();
                ReturnToMenu.ToLower();
            }
            if (ReturnToMenu == "no")
            {
                Console.WriteLine($"Exit the program?\n {command}");
                Exit = Console.ReadLine();
            }
        }           
    }
}
