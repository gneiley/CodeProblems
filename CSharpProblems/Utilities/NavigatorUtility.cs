using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProblems.Utilities
{
    public class NavigatorUtility : BaseClass
    {
        public static void Navigate()
        {
            if (KeepGoing == "no")
            {
                Console.WriteLine("Return to main menu?");
                ReturnToMenu = Console.ReadLine();
                ReturnToMenu.ToLower();
            }
            if (ReturnToMenu == "no")
            {
                Console.WriteLine("Exit the program?");
                Exit = Console.ReadLine();
            }
        }           
    }
}
