using CSharpProblems.Utilities;
using CSharpProblems.Models;

namespace CSharpProblems
{
    public class BaseClass
    {
        public static string KeepGoing = "yes";

        public static string ReturnToMenu = "yes";

        public static string Exit = "no";

        public static readonly string MaskifyString = StringFormattingUtility.AddSpacesToString(FunctionLabels.MaskNumberString.ToString());

        public static readonly string StrangePairString = StringFormattingUtility.AddSpacesToString(FunctionLabels.CheckForStrangeStringPair.ToString());

        public static readonly int MaskifyInt = (int)FunctionLabels.MaskNumberString;

        public static readonly int StrangePairsInt = (int)FunctionLabels.CheckForStrangeStringPair;
    }
}
