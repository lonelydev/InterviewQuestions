﻿using System.Linq;

namespace TheMaximumNumberWithAllDigitsInANumber.Problem
{
    public class MaxNumberFinder
    {
        public static long MaxNumberWithAllDigitsInANumber(long number)
        {            
            var sortedCharArrayString = string.Join("", number.ToString()
                    .ToCharArray()
                    .OrderByDescending(e => e)
                    .ToArray());
            return long.Parse(sortedCharArrayString);
        }
    }
}
