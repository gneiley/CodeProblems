using CSharpProblems.Utilities;
using CSharpProblems.Models;

namespace CSharpProblems
{
    public class BaseClass
    {
        //Navigation 

        public static string KeepGoing = "yes";

        public static string ReturnToMenu = "yes";

        public static string Exit = "no";

        //Set names

        public static readonly string MaskifyString = StringFormattingUtility.AddSpacesToString(FunctionLabels.MaskNumberString.ToString());

        public static readonly string StrangePairString = StringFormattingUtility.AddSpacesToString(FunctionLabels.CheckForStrangeStringPair.ToString());

        public static readonly string FilterArrayString = StringFormattingUtility.AddSpacesToString(FunctionLabels.FilterOutStringsFromAnArray.ToString());

        //Set numbers

        public static readonly int MaskifyInt = (int)FunctionLabels.MaskNumberString;

        public static readonly int StrangePairsInt = (int)FunctionLabels.CheckForStrangeStringPair;

        public static readonly int FilterArrayInt = (int)FunctionLabels.FilterOutStringsFromAnArray;
    }
}
