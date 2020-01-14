using System;
using System.Collections.Generic;
using System.Text;
using DSA;

namespace CTCISolutions
{
    public class ChapterTwo
    {
        //Rudimentary approach; For each node, compare to each other node
        //Inefficient, and using LinkedList methods instead of actually manipulating the data structure
        public void RemoveDups(LinkedList inputList)
        {
            LinkedList outputList = new LinkedList();

            for (int i = 0; i < inputList.Count - 1; i++)
            {
                for(int j = i + 1; j < inputList.Count - 1; j++)
                {
                    if (inputList.ValueAt(i) == inputList.ValueAt(j))
                        inputList.RemoveAtIndex(j);
                }
            }
        }

        //Implementation which 1. Utilizes a HashSet for efficient lookup of node values and 2. performs the actual reference manipulation
        //Far better than the stinky implementation above
        public void RemoveDupsWithDict(LinkedList inputList)
        {
            Node current = inputList.Head;
            HashSet<int> listValues = new HashSet<int>();
            while(current != null)
            {
                if (!listValues.Contains(current.Value))
                {
                    listValues.Add(current.Value);
                }
                else
                {
                    current.Previous.Next = current.Next;
                    if (current.Next != null)
                        current.Next.Previous = current.Previous;
                }
                current = current.Next;
            }
        }

        //The index of the Kth to last element is the Count of the List minus K
        //So simply traverse to that node and return its value
        public int KthToLast(LinkedList inputList, int k)
        {
            if (k > inputList.Count)
                throw new IndexOutOfRangeException("Invalid input for K - out of range of list");

            Node current = inputList.Head;
            int indexofElement = inputList.Count - k;
            for (int i = 0; i < indexofElement; i++)
            {
                current = current.Next;
            }
            return current.Value;
        }

        //Removes the provided "middle" node
        //Checks if the next node is null - indicating this is the last node - as well as normal null check
        //My LinkedList implementation is doubly linked however we disregard that and treat it as though it is singly linked
        public void RemoveMiddleNode(Node input)
        {
            if (input.Next == null || input == null)
                throw new InvalidOperationException("Cannot remove this node - it is the last node or it is null.");
            else
            {
                Node newNode = input.Next;
                input.Value = newNode.Value;
                input.Next = newNode.Next;
            }
        }
    }
}
