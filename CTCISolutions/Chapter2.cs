using System;
using System.Collections.Generic;
using System.Text;
using DSA;

namespace CTCISolutions
{
    public class Chapter2
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

        //This implementation uses the assumption that the numbers are stored in reverse order
        public LinkedList SumLists(LinkedList list1, LinkedList list2)
        {
            LinkedList sumList = new LinkedList();
            Node currentList1 = list1.Head;
            Node currentList2 = list2.Head;
            int carry = 0;
            //Loop through the two lists side-by-side as long as at least one of them still has values
            while(currentList1 != null || currentList2 != null)
            {
                //In the cases where one number/list is longer than the other, we add 0 to the other digit
                int currentSumDigit = ((currentList1 != null) ? currentList1.Value : 0) + ((currentList2 != null) ? currentList2.Value : 0);
                //Apply carry digit if applicable
                if (carry == 1)
                {
                    currentSumDigit++;
                    carry = 0;
                }
                if(currentSumDigit > 9)
                {
                    //Set carry for additions greater than 9 and add the 1s digit to the list
                    carry = 1;
                    currentSumDigit = currentSumDigit % 10;
                    sumList.InsertLast(currentSumDigit);
                }
                //Otherwise just add the digit
                else
                    sumList.InsertLast(currentSumDigit);
                //Incrememt the lists' references, or null when one number has been fully traversed through
                currentList1 = currentList1?.Next;
                currentList2 = currentList2?.Next;
            }
            return sumList;
        }

        public bool IsPalindrome(LinkedList input)
        {
            Node startNode = input.Head;
            Node endNode = input.Tail;
            while(startNode != endNode)
            {
                if (startNode.Value != endNode.Value)
                    return false;
                else
                {
                    startNode = startNode.Next;
                    endNode = endNode.Previous;
                }
            }
            return true;
        }
    }
}
