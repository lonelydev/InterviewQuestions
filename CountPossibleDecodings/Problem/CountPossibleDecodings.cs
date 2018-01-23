using System;
using System.Collections.Generic;

namespace CountPossibleDecodingsQuestion.Problem
{
    /// <summary>
    /// For so A =1, Z=>26
    /// digitSequence can come in 123, 6574 etc.
    /// The simplest case would always be 1 char for 1 alphabet.  
    /// That is for granted. So we don't need to calculate that. 
    /// The case we need to numberOfDecodings is really how many combination of 
    /// numbers are there in the digitSequence string that are less than 27.
    /// So iterate through the digitSequence string in pairs to see if the pair forms
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
                var count = NumberOfDecodedStringsRecursive(consoleInput.InputString);
                Console.WriteLine(count);
                Console.ReadKey();
            }
        }        

        /// <summary>
        /// NumberOfDecodedStrings("1234") = NumberOfDecodedStrings("123")4 + NumberNumberOfDecodedStrings("12")34
        /// NumberOfDecodedStrings("123") = NumberOfDecodedStrings("12") + NumberNumberOfDecodedStrings("3") + NumberNumberOfDecodedStrings("34");
        /// NumberOfDecodedStrings("12") = NumberOfDecodedStrings("1") + = NumberOfDecodedStrings("2") 
        /// NumberOfDecodedStrings("1234") = NumberOfDecodedStrings("12") + NumberNumberOfDecodedStrings("34");
        /// </summary>
        /// <param name="digits"></param>
        /// <returns></returns>
        public static int NumberOfDecodedStringsRecursive(string digitSequence)
        {
            var lengthOfInput = digitSequence.Length;
            // the note in the readme is our base case:
            // `An empty digit sequence is considered to have one decoding`
            if (lengthOfInput == 0)
            {
                return 1;
            }
            else if (lengthOfInput == 1)
            {
                // only one digit and if it is nonzero digit then it has a decoding, else no decodings possible
                if (digitSequence != "0") return 1;
                return 0;
            }

            // Now let us recurse through the problem. 
            // Extract the last digit and see if it is nonzero, in which case, we should add its decodings to numberOfDecodings.
            var numberOfDecodings = 0;
            var lastChar = (int) Char.GetNumericValue(digitSequence[lengthOfInput - 1]);
            if (lastChar > 0)
            {
                numberOfDecodings = NumberOfDecodedStringsRecursive(digitSequence.Substring(0, lengthOfInput - 1));
            }
            // Now that we have counted the decodings of the last digit in the sequence, 
            // Extract the last two digits to see if they have valid decodings. 
            // Decodings are valid if the number x, formed by last two digits, is:
            // 10 <= x < 27
            // Then count the 
            var secondLastChar = (int) Char.GetNumericValue(digitSequence[lengthOfInput - 2]);
            var lastTwoChars = secondLastChar * 10 + lastChar;
            if (secondLastChar == 1 || (secondLastChar == 2 && lastChar < 7))
                numberOfDecodings += NumberOfDecodedStringsRecursive(digitSequence.Substring(0, lengthOfInput - 2));

            return numberOfDecodings;
        }

        /// <summary>
        /// This solution is a non-recursive version. 
        /// Using memoization - a technique where results of previous calculations are stored to be retrieved in 
        /// later calculations. 
        /// * counter is an integer array that we use to count number of decodings. 
        ///     * the i'th element of counter holds the number of decodings for i elements. 
        /// </summary>
        /// <param name="digits"></param>
        /// <returns></returns>
        public static int NumberOfDecodedStringsNonRecursive(string digits)
        {
            var counter = new int[digits.Length + 1];
            // This is the base case - empty digit sequence means, 1 decoding
            counter[0] = 1;

            // if digit sequence is of length 1 and it is a nonzero digit then again, we have 1 decoding. 
            if (digits[0] != '0')
                counter[1] = 1;
            else
                counter[1] = 0;
            // iterate through the rest of the digit sequence 
            for (int i = 2; i <= digits.Length; i++)
            {
                counter[i] = 0;
                var lastChar = (int) Char.GetNumericValue(digits[i - 1]);
                if (lastChar > 0)
                {
                    counter[i] = counter[i - 1];
                }
                var secondLastChar = (int) Char.GetNumericValue(digits[i - 2]);
                var lastTwoChars = secondLastChar * 10 + lastChar;
                if (secondLastChar == 1 || (secondLastChar == 2 && lastChar < 7))
                    counter[i] += counter[i - 2];
            }
            return counter[digits.Length];
        }
    }
}
