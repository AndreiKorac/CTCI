using System;

namespace DSA
{
    public class LinkedList
    {
        public Node Head { get; set; }
        public int Count { get; set; }

        public void InsertLast(int value)
        {
            if (Head == null)
            {
                Head = new Node(value);
                Count++;
            }
            else
            {
                Node newNode = new Node(value);
                Node current = Head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
                Count++;
            }
        }

        public void InsertAfter(int value, int index)
        {
            if(index > Count)
            {
                throw new IndexOutOfRangeException("Index is out of range of List");
            }
            Node newNode = new Node(value);
            Node current = Head;
            for (int i = 0; i < index - 1; i++)
            {
                current = current.Next;
            }
            newNode.Next = current.Next;
            current.Next = newNode;
            Count++;
        }

        public void InsertStart(int value)
        {
            if(Head == null)
            {
                Head = new Node(value);
                Count++;
            }
            else
            {
                Node newNode = new Node(value);
                newNode.Next = Head;
                Head = newNode;
                Count++;
            }
        }

        public void RemoveFirst()
        {
            if(Head == null)
            {
                throw new InvalidOperationException("Cannot remove from an empty list");
            } 
            if(Head.Next == null)
            {
                Head = null;
                Count--;
            }
            else
            {
                Head = Head.Next;
                Count--;
            }
        }

        public void RemoveLast()
        {
            if (Head == null)
            {
                throw new InvalidOperationException("Cannot remove from an empty list");
            }
            if(Head.Next == null)
            {
                Head = null;
                Count--;
            }
            else
            {
                Node current = Head;
                while (current.Next.Next != null)
                {
                    current = current.Next;
                }
                current.Next = null;
                Count--;
            }
        }

        public void RemoveAtIndex()
        {

        }

        public bool Contains(int value)
        {
            Node current = Head;

            for(int i = 0; i < Count; i++)
            {
                if (current.Value == value)
                    return true;
                current = current.Next;
            }
            return false;
        }

        public int ValueAt(int index)
        {
            if(index > Count - 1 || index < 0) throw new IndexOutOfRangeException("Index is out of range of List");

            Node current = Head;
            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }
            return current.Value;
        }
    }

    public class Node
    {
        public Node Next { get; set; }
        public int Value { get; set; }

        public Node(int value)
        {
            Value = value;
        }
    }
}
