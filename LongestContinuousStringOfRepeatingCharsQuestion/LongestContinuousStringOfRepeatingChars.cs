using System;
using System.Text;
using System.Collections.Generic;

namespace LongestContinuousStringOfRepeatingChars.Solution
{
    /// <summary>
    /// Given an input string, divide it into substrings where each substring contains the 
    /// longest continuous string of the same character and output a string with the character 
    /// for each substring and the length of the respective substring
    /// example: currentPosition think this is wrong below
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
    public class LongestUniformString
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


        /// <summary>
        /// This one returns a tuple containing the 
        ///   * index of the start of the longest uniform substring
        ///   * longest uniform substring
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns></returns>
        public static Tuple<int, string> GetLongestUniformubstringsAndStartIndex(string inputString)
        {            
            var bufferOfStringSoFar = new StringBuilder();
            var prev = inputString[0];
            var startOfCurrentChar = 0;
            var longestUniformStringLength = 0;
            var longestUniformString = "";
            var tuple = new Tuple<int, string>(0, "");
            for (int currentPosition = 1; currentPosition < inputString.Length; currentPosition++)
            {
                if (prev != inputString[currentPosition])
                {                    
                    longestUniformString = inputString.Substring(startOfCurrentChar, currentPosition - startOfCurrentChar);
                    if (longestUniformString.Length > longestUniformStringLength)
                    {
                        tuple = new Tuple<int, string> (startOfCurrentChar, longestUniformString);
                        longestUniformStringLength = longestUniformString.Length;
                    }
                    startOfCurrentChar = currentPosition;
                    prev = inputString[currentPosition];
                }
            }            
            return tuple;
        }
    }
}
