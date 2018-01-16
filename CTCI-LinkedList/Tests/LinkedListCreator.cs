using System.Collections.Generic;

namespace CTCI_LinkedList.Tests
{
    public class LinkedListCreator
    {
        public static SinglyLinkedList CreateSinglyLinkedListFromGenericList(List<int> inputList)
        {
            SinglyLinkedList node = null;
            for (int i = 0; i < inputList.Count; i++)
            {
                if (i == 0)
                {
                    node = new SinglyLinkedList(inputList[i]);
                }
                else
                {
                    node.AppendToTail(inputList[i]);
                }
            }
            return node;
        }
    }
}
