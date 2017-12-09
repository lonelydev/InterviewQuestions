using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountPossibleDecodingsQuestion
{
    /// <summary>
    /// For so A =1, Z=>26
    /// input can come in 123, 6574 etc.
    /// The simplest case would always be 1 char for 1 alphabet.  
    /// That is for granted. So we don't need to calculate that. 
    /// The case we need to count is really how many combination of 
    /// numbers are there in the input string that are less than 27.
    /// So iterate through the input string in pairs to see if the pair forms
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
                var count = CountAlphabetsDecoded(consoleInput.InputString, consoleInput.Length);
                Console.WriteLine(count);
                Console.ReadKey();
            }            
        }

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
    }
}
