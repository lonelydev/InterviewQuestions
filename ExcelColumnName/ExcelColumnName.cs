using System;
using System.Collections.Generic;
using System.Text;

namespace ExcelColumnNameQuestion
{
    public class ExcelColumnName
    {        
        public static void Main(string[] args)
        {            
            var numOfTests = Console.ReadLine();
            int numberOfTests = int.Parse(numOfTests);
            var listOfColNumbers = new List<int>();
            while(numberOfTests > 0)
            {
                var colNum = Console.ReadLine();
                var columnNumber = int.Parse(colNum);
                listOfColNumbers.Add(columnNumber);
                numberOfTests--;
            }
            foreach(var colNum in listOfColNumbers)
            {
                Console.WriteLine(GetColumnName(colNum));
            }
        }

        public static string GetColumnName(int num)
        {            
            var colName = new StringBuilder();
            while (num>0)
            {
                int remainder = num % 26;
                if(remainder == 0)
                {
                    colName.Append("Z");
                    num = (num / 26) - 1;
                }else
                {
                    colName.Append((char)(remainder + 65 - 1));
                    num = num / 26;
                }
            }
            var colNameString = colName.ToString();
            var colNameCharArray = colNameString.ToCharArray();
            Array.Reverse(colNameCharArray);
            return string.Join("",colNameCharArray);
        }
    }
}
