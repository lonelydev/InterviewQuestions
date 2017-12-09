using System.Collections.Generic;

namespace LongestContinuousStringOfRepeatingCharsQuestion
{
    /// <summary>
    /// Given an input string, divide it into substrings where each substring contains the 
    /// longest continuous string of the same character and output a string with the character 
    /// for each substring and the length of the respective substring
    /// example: i think this is wrong below
    /// if input is Malayalam
    /// aaa
    /// mm
    /// ll
    /// y
    /// correct example would be:
    ///   - input: geeksforgeeks
    ///   - output: ee 2
    /// 
    ///   - input: abbbbbaaafccccccccdd
    ///   - output:
    ///             bbbbb 5
    ///             aaa 3
    ///             cccccccc 8
    ///             dd 2 
    /// </summary>
    public class LongestContinuousStringOfRepeatingChars
    {
        public static List<string> GetRepititiveCharSubstringsAndLengths(string inputString)
        {
            var listOfSubstrings = new List<string>();
            var prev = inputString[0];
            var start = 0;
            for (int i = 1; i < inputString.Length; i++)
            {
                if (prev != inputString[i])
                {
                    listOfSubstrings.Add(inputString.Substring(start, i - start));
                    start = i;
                    prev = inputString[i];
                }
            }
            listOfSubstrings.Add(inputString.Substring(start));
            return listOfSubstrings;
        }
    }
}
