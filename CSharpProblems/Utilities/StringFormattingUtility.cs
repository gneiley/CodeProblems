using System.Collections.Generic;

namespace CSharpProblems.Utilities
{
    public class StringFormattingUtility
    {
        public static string AddSpacesToString(string sentance)
        {
            char[] arrayWithoutSpaces = sentance.ToCharArray();
            List<char> listWithSpaces = new List<char>();
            
            for(int i = 0; i < arrayWithoutSpaces.Length; i++)
            {
                if(char.IsUpper(arrayWithoutSpaces[i]) && i != 1)
                {
                    listWithSpaces.Add(' ');
                    listWithSpaces.Add(arrayWithoutSpaces[i]);
                }
                else
                {
                    listWithSpaces.Add(arrayWithoutSpaces[i]);
                }
            }
            char[] x = listWithSpaces.ToArray();
            return new string(x);
        }
    }
}