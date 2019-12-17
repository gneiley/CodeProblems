using System;
using CSharpProblems.Models;

namespace CSharpProblems.Utilities
{
    public class InputConverter : BaseClass
    {
        public static int ConvertMainMenuChoice()
        {
            string input = Console.ReadLine();

            FunctionLabels method = input == StrangePairsInt.ToString() ? FunctionLabels.CheckForStrangeStringPair :
                input == MaskifyInt.ToString() ? FunctionLabels.MaskNumberString :
                input == FilterArrayInt.ToString() ? FunctionLabels.FilterOutStringsFromAnArray :
                FunctionLabels.IncorrectInput;

            return (int)method;
        }
    }
}