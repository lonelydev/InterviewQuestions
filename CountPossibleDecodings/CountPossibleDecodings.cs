using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountPossibleDecodingsQuestion
{
    /// <summary>
    /// For so A =1, Z=>26
    /// digits can come in 123, 6574 etc.
    /// The simplest case would always be 1 char for 1 alphabet.  
    /// That is for granted. So we don't need to calculate that. 
    /// The case we need to count is really how many combination of 
    /// numbers are there in the digits string that are less than 27.
    /// So iterate through the digits string in pairs to see if the pair forms
    /// a valid number less than 27. 
    /// If that is true, then that and the rest of the string as individual alphabets is another combination
    /// if there are multiple pairs less than 27
    /// </summary>
    public class CountPossibleDecodings
    {
        public class ConsoleInput
        {
            private int lengthOfInput;
            private string inputString;

            public int Length { get { return lengthOfInput; } }
            public string InputString { get { return inputString; } }

            public ConsoleInput(int lot, string inp)
            {
                lengthOfInput = lot;
                inputString = inp;
            }
        }

        public static void Main(string[] args)
        {
            var listOfConsoleInputs = new List<ConsoleInput>();
            var not = Console.ReadLine();
            var numberOfTests = int.Parse(not);
            while (numberOfTests > 0)
            {
                var lengthOfInput = Console.ReadLine();
                var input = Console.ReadLine();
                listOfConsoleInputs.Add(new ConsoleInput(int.Parse(lengthOfInput), input));                
                numberOfTests--;
            }
            foreach (var consoleInput in listOfConsoleInputs)
            {
                var count = NumberOfDecodedStringsRecursive(consoleInput.InputString, consoleInput.Length);
                Console.WriteLine(count);
                Console.ReadKey();
            }            
        }

        /// <summary>
        /// INCORRECT IMPLEMENTATION
        /// </summary>
        /// <param name="input"></param>
        /// <param name="lengthOfInput"></param>
        /// <returns></returns>
        public static int CountAlphabetsDecoded(string input, int lengthOfInput)
        {
            var count = 0;
            var containsZero = false;
            for(int i = 0; i < lengthOfInput - 1; i++)
            {
                if (input[i] == '0' && count > 0)
                {
                    //leading 0 and two or more consecutive zeros are invalid
                    //count--;
                    containsZero = true;
                    continue;
                }
                var twoCharStringFromIndex = input.Substring(i, 2);                
                var parsedInteger = int.Parse(twoCharStringFromIndex);
                if (parsedInteger < 27)
                {
                    count++;
                }
            }
            if (!containsZero) count++;
            return count;
        }

        /// <summary>
        /// NumberOfDecodedStrings("1234") = NumberOfDecodedStrings("123")4 + NumberNumberOfDecodedStrings("12")34
        /// NumberOfDecodedStrings("123") = NumberOfDecodedStrings("12") + NumberNumberOfDecodedStrings("3") + NumberNumberOfDecodedStrings("34");
        /// NumberOfDecodedStrings("12") = NumberOfDecodedStrings("1") + = NumberOfDecodedStrings("2") 
        /// NumberOfDecodedStrings("1234") = NumberOfDecodedStrings("12") + NumberNumberOfDecodedStrings("34");
        /// </summary>
        /// <param name="digits"></param>
        /// <param name="lengthOfInput"></param>
        /// <returns></returns>
        public static int NumberOfDecodedStringsRecursive(string digits, int lengthOfInput)
        {
            if (lengthOfInput == 0)
            {
                return 1;
            }
            else if (lengthOfInput == 1)
            {
                if (digits != "0") return 1;
                return 0;
            }
            var count = 0;
            var lastChar = int.Parse(digits[lengthOfInput - 1].ToString());
            if (lastChar > 0)
            {
                count = NumberOfDecodedStringsRecursive(digits.Substring(0, lengthOfInput - 1), lengthOfInput - 1);
            }

            var secondLastChar = int.Parse(digits[lengthOfInput - 2].ToString());
            var lastTwoChars = secondLastChar * 10 + lastChar;
            if (secondLastChar == 1 || (secondLastChar == 2 && lastChar < 7))
                count += NumberOfDecodedStringsRecursive(digits.Substring(0, lengthOfInput - 2), lengthOfInput - 2);

            return count;
        }

        /// <summary>
        /// Wrote the previous method without thinking much. 
        /// length of input can be derived from the input string anyway. 
        /// it might have been more useful in languages like c
        /// </summary>
        /// <param name="digits"></param>
        /// <returns></returns>
        public static int NumberOfDecodedStringsRecursive(string digits)
        {
            var lengthOfInput = digits.Length;
            var count = 0;
            if (lengthOfInput < 2 && lengthOfInput >= 0) return 1;
            var lastChar = int.Parse(digits[lengthOfInput - 1].ToString());

            if (lastChar > 0)
            {
                count = NumberOfDecodedStringsRecursive(digits.Substring(0, lengthOfInput - 1));
            }

            var secondLastChar = int.Parse(digits[lengthOfInput - 2].ToString());

            //01, 02...09 are invalid. so count only non-zero
            if (secondLastChar != 0)
            {
                var lastTwoChars = secondLastChar * 10 + lastChar;
                if ((lastTwoChars) < 27 && lastTwoChars > 0)
                    count += NumberOfDecodedStringsRecursive(digits.Substring(0, lengthOfInput - 2));
            }
            return count;
        }
    }
}
