using System;
using CSharpProblems.Functions;
using CSharpProblems.Models;
using CSharpProblems.Utilities;

namespace CSharpProblems
{
    public class Program : BaseClass
    {
        static void Main(string[] args)
        {
            while(ReturnToMenu == "yes")
            {
                SelectAndRunProgram();
            }
        }

        public static void SelectAndRunProgram()
        {
            KeepGoing = "yes";

            Console.WriteLine("What program would you like to run?\n" +
                "Please type the number associated to the program you'd like to use, and press Enter.\n" +
                $"{StrangePairsInt} = {StrangePairString}\n" +
                $"{MaskifyInt} = {MaskifyString}\n" +
                $"{FilterArrayInt} = {FilterArrayString}"
                );

            switch (InputConverter.ConvertMainMenuChoice())
            {
                case 1:
                    StrangePairs.RunIsStrangeStringPair();
                    break;

                case 2:
                    Maskify.RunMaskifyNumbers();
                    break;

                case 3:
                    FilterArray.RunFilterArray();
                    break;

                default:
                    Console.WriteLine("Error");
                    break;
            }

        }
    }
}      