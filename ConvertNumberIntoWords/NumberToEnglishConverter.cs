using System;
using System.Collections.Generic;
using System.Text;

namespace ConvertNumberIntoWords
{
    public class NumberToEnglishConverter
    {
        private readonly Dictionary<int, string> unitPlace =
            new Dictionary<int, string>() {
                { 0, ""},
                { 1, "one"}, { 2, "two" }, { 3, "three" },
                { 4, "four" }, { 5, "five"}, {6, "six"},
                { 7, "seven"}, {8, "eight"}, {9, "nine"}
            };

        private readonly Dictionary<int, string> twoDigitsThatStartWithOne =
            new Dictionary<int, string>()
            {
                {10, "ten" },
                {11, "eleven" },
                {12, "twelve" },
                {13, "thirteen" },
                {14, "fourteen" },
                {15, "fifteen" },
                {16, "sixteen" },
                {17, "seventeen" },
                {18, "eighteen" },
                {19, "nineteen" }
            };

        private readonly Dictionary<int, string> tensMultiples =
            new Dictionary<int, string>()
            {                
                {2, "twenty"},
                {3, "thirty" },
                {4, "forty" },
                {5, "fifty" },
                {6, "sixty" },
                {7, "seventy" },
                {8, "eighty" },
                {9, "ninety" },
            };                

        private readonly Dictionary<int, string> numberPositionKeywords =
            new Dictionary<int, string>()
            {                
                {4, "thousand" },
                {3, "hundred" }
            };

        /// <summary>
        /// The method that converts an integer to an English word
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static string ToEnglish(int number)
        {
            var numberInEnglish = new StringBuilder();
            var numEnglishConverter = new NumberToEnglishConverter();
            //convert input number into a char array;
            var numberChars = number.ToString().ToCharArray();
            var penultimateWasOne = false;
            
            for (int i = 0; i < numberChars.Length; i++)
            {
                var numericValueOfChar = (int)Char.GetNumericValue(numberChars[i]);
                // find out what position this char is in. 
                // is it in 10000s, 1000s, 100s, 10s, etc.
                var numPosition = numberChars.Length - i;
                if (numPosition < 2 && penultimateWasOne)
                    break;
                switch (numPosition)
                {
                    // deal with 1000s
                    case 4:                        
                    case 3:
                        // if there is a number at this position, then you have ot print that number and 'hundred'
                        if (numericValueOfChar > 0)
                        {
                            numberInEnglish.Append(numEnglishConverter.unitPlace[numericValueOfChar]);
                            numberInEnglish.Append(" ");
                            numberInEnglish.Append(numEnglishConverter.numberPositionKeywords[numPosition]);
                        }
                        break;
                    case 2:
                        switch (numericValueOfChar)
                        {
                            case 0:
                                //nothing to do here
                                break;
                            case 1:
                                // either set a flag and continue so that in the next iteration we 
                                // finally print the english equivalent of the 2 digits
                                penultimateWasOne = true;
                                // get the next digit too
                                var lastTwoDigitNumber = numericValueOfChar * 10 + (int)Char.GetNumericValue(numberChars[i + 1]);
                                numberInEnglish.Append(numEnglishConverter.twoDigitsThatStartWithOne[lastTwoDigitNumber]);
                                break;
                            default:
                                // any digit greater than 1 to 9
                                numberInEnglish.Append(numEnglishConverter.tensMultiples[numericValueOfChar]);
                                break;
                        }
                        break;
                    case 1:
                        numberInEnglish.Append(numEnglishConverter.unitPlace[numericValueOfChar]);
                        break;
                    default:
                        break;
                }
                if (numPosition > 1 && !penultimateWasOne && numericValueOfChar > 0)
                    numberInEnglish.Append(" ");
            }
            return numberInEnglish.ToString().Trim();
        }
    }
}
