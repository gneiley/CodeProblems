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
            Console.WriteLine("What program would you like to run?\n" +
                "Please type the number associated to the action you'd like, and press Enter.\n" +
                $"{StrangePairsInt} = {StrangePairString}\n" +
                $"{MaskifyInt} = {MaskifyString}"
                );
            string input = Console.ReadLine();

            Methods method = input == StrangePairsInt.ToString() ? Methods.CheckForStrangeStringPair :
                input == MaskifyInt.ToString() ? Methods.MaskNumberString : Methods.IncorrectInput;

            switch ((int)method)
            {
                case 1:
                    StrangePairs.RunIsStrangeStringPair();
                    break;

                case 2:
                    Maskify.RunMaskifyNumbers();
                    break;

                default:
                    Console.WriteLine(StringFormattingUtility.AddSpacesToString(method.ToString()));
                    break;
           }            
        }
    }
}      