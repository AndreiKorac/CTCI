using System;

namespace DSA
{
    public class LinkedList
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }
        public int Count { get; set; }

        public void InsertLast(int value)
        {
            Node newNode = new Node(value);
            if (Head == null)
            {
                Head = newNode;
                Tail = newNode;
                Count++;
            }
            else
            {
                Tail.Next = newNode;
                newNode.Previous = Tail;
                Tail = newNode;
                Count++;
            }
        }

        public void InsertAfter(int value, int index)
        {
            if(index > Count - 1 || index < 0)
            {
                throw new IndexOutOfRangeException("Index is out of range of List");
            }
            if(index == Count - 1)
            {
                InsertLast(value);
            }
            else
            {
                Node newNode = new Node(value);
                Node current = Head;

                for (int i = 0; i < index; i++)
                {
                    current = current.Next;
                }
                newNode.Next = current.Next;
                newNode.Previous = current;
                current.Next.Previous = newNode;
                current.Next = newNode;
                Count++;
            }
        }

        public void InsertStart(int value)
        {
            if(Head == null)
            {
                Node newNode = new Node(value);
                Head = newNode;
                Tail = newNode;
                Count++;
            }
            else
            {
                Node newNode = new Node(value);
                newNode.Next = Head;
                Head.Previous = newNode;
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
                Tail = null;
                Count--;
            }
            else
            {
                Head = Head.Next;
                Head.Previous = null;
                Count--;
            }
        }

        public void RemoveLast()
        {
            if (Tail == null)
            {
                throw new InvalidOperationException("Cannot remove from an empty list");
            }
            if(Head.Next == null)
            {
                Head = null;
                Tail = null;
                Count--;
            }
            else
            {
                Tail = Tail.Previous;
                Tail.Next = null;
                Count--;
            }
        }

        public void RemoveAtIndex(int index)
        {
            if (index == 0)
                RemoveFirst();
            else if (index == Count - 1)
                RemoveLast();
            else
            {
                Node current = Head;
                for (int i = 0; i < index; i++)
                {
                    current = current.Next;
                }
                current.Previous.Next = current.Next;
                current.Next.Previous = current.Previous;
                Count--;
            }
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
        public Node Previous { get; set; }
        public int Value { get; set; }

        public Node(int value)
        {
            Value = value;
        }
    }
}
