using System;
using System.Collections.Generic;

namespace QueueTaleOfTwoStacks
{
    public class Solution
    {
        public static void Main(string[] args)
        {
            QueueOfTwoStacks qOts = new QueueOfTwoStacks();
            var numberOfQueries = int.Parse(Console.ReadLine());
            List<KeyValuePair<int, int>> operationsList = new List<KeyValuePair<int, int>>();
            for (int i = 0; i < numberOfQueries; i++)
            {
                var operation = Console.ReadLine();
                var operationAndOperandPair = IdentifyOperationAndOperand(operation);
                operationsList.Add(operationAndOperandPair);
            }

            foreach (var keyValuePair in operationsList)
            {
                switch (keyValuePair.Key)
                {
                    case 1:
                        //1 x: Enqueue element into the end of the queue.
                        Console.WriteLine("Inserting {0}", keyValuePair.Value);
                        qOts.Enqueue(keyValuePair.Value);
                        break;
                    case 2:
                        //2: Dequeue the element at the front of the queue.
                        Console.WriteLine("Dequeuing from queue {0}", qOts.Dequeue());
                        break;
                    //case 3:
                    //    //3: Print the element at the front of the queue.
                    //    Console.WriteLine(qOts.Peek());
                    //    break;
                    default:
                        //throw exception
                        break;
                }
            }
            Console.ReadLine();
        }

        public static KeyValuePair<int, int> IdentifyOperationAndOperand(string operation)
        {
            var operationAndOperand = operation.Split(' ');
            if (operationAndOperand.Length < 2)
            {
                return new KeyValuePair<int, int>(int.Parse(operationAndOperand[0]), 0);
            }
            return new KeyValuePair<int, int>(int.Parse(operationAndOperand[0]), int.Parse(operationAndOperand[1]));
        }
    }
}
