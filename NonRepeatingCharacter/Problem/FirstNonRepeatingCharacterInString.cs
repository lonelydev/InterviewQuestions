using System;
using System.Collections.Generic;

namespace FirstNonRepeatingCharacterInStringQuestion.Problem
{
    public class FirstNonRepeatingCharacterInString
    {
        public static void Main(string[] args)
        {
            var not = Console.ReadLine();
            var numberOfTestCases = int.Parse(not);
            var listOfStrings = new List<StringsLengths>();
            while (numberOfTestCases> 0)
            {
                var los = Console.ReadLine();
                var lengthOfString = int.Parse(los);

                var inputString = Console.ReadLine();
                listOfStrings.Add(new StringsLengths(lengthOfString, inputString));
                numberOfTestCases--;
            }
            foreach (var strLengths in listOfStrings)
            {
                Console.WriteLine(NonRepeatingCharacter(strLengths));
            }
            Console.ReadKey();
        }        

        public static string NonRepeatingCharacter(StringsLengths strLength)
        {
            Dictionary<char, int> characterMap = new Dictionary<char, int>();
            foreach(var c in strLength.InputString)
            {
                if (characterMap.ContainsKey(c))
                {
                    characterMap[c] = characterMap[c] + 1;
                }
                else
                {
                    characterMap.Add(c, 1);
                }
            }

            foreach(var c in strLength.InputString)
            {
                if (characterMap[c] < 2)
                    return c.ToString();
            }

            return "-1";
        }
    }
}
