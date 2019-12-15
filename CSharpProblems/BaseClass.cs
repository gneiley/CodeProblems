using CSharpProblems.Utilities;
using CSharpProblems.Models;

namespace CSharpProblems
{
    public class BaseClass
    {
        public static string keepGoing = "yes";

        public static readonly string MaskifyString = StringFormattingUtility.AddSpacesToString(Methods.MaskNumberString.ToString());

        public static readonly string StrangePairString = StringFormattingUtility.AddSpacesToString(Methods.CheckForStrangeStringPair.ToString());

        public static readonly int MaskifyInt = (int)Methods.MaskNumberString;

        public static readonly int StrangePairsInt = (int)Methods.CheckForStrangeStringPair;
    }
}
