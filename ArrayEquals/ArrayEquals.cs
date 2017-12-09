using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayEqualsQuestion
{
    class ArrayEquals
    {
        public class InputFromConsole
        {

            public int NumberOfElements;
            public List<int> InputList1 = new List<int>();
            public List<int> InputList2 = new List<int>();
        }

        public static void Main()
        {
            var not = Console.ReadLine();
            var numberOfTests = int.Parse(not);
            var listOfInputs = new List<InputFromConsole>();
            while (numberOfTests > 0)
            {
                var noe = Console.ReadLine();
                var numberOfElements = int.Parse(noe);
                var input1 = Console.ReadLine();
                var input2 = Console.ReadLine();
                var inputList1 = input1.Split(' ').Select(c => int.Parse(c)).ToList();
                var inputList2 = input2.Split(' ').Select(c => int.Parse(c)).ToList();
                listOfInputs.Add(new InputFromConsole
                {
                    NumberOfElements = numberOfElements,
                    InputList1 = inputList1,
                    InputList2 = inputList2
                });
                numberOfTests--;
            }
            foreach (var input in listOfInputs)
            {
                Console.WriteLine(AreEqual(input.NumberOfElements, input.InputList1, input.InputList2));
            }
            Console.ReadKey();
        }

        /// <summary>
        /// this is one way of doing it. 
        /// another way is to sort the arrays and compare like for likes
        /// </summary>
        /// <param name="n"></param>
        /// <param name="input1"></param>
        /// <param name="input2"></param>
        /// <returns></returns>
        public static int AreEqual(int n, List<int> input1, List<int> input2)
        {
            if (input1.Count != input2.Count || input1.Count != n || input2.Count!= n)
            {
                return 0;
            }

            var elementCountDict = new Dictionary<int, int>();
            for (int i = 0; i < n; i++)
            {
                if (elementCountDict.ContainsKey(input1[i]))
                {
                    elementCountDict[input1[i]]++;
                }
                else
                {
                    elementCountDict.Add(input1[i], 1);
                }

            }
            for (int i = 0; i < n; i++)
            {
                if (elementCountDict.ContainsKey(input2[i]))
                {
                    elementCountDict[input2[i]]--;
                }
                else
                {
                    elementCountDict.Add(input2[i], 1);
                }
            }

            foreach(var keyVal in elementCountDict)
            {
                if (keyVal.Value != 0) return 0;                
            }
            return 1;
        }
    }
}
