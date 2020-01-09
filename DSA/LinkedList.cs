using System;

namespace DSA
{
    public class LinkedList
    {
        public Node Head { get; set; }
        public int Count { get; set; }

        public void Append(int d)
        {
            if (Head == null)
            {
                Head = new Node(d);
                Count++;
            }
            else
            {
                Node newNode = new Node(d);
                Node current = Head;
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = newNode;
                Count++;
            }
        }

        public void AppendAtIndex(int d, int index)
        {
            if(index > Count)
            {
                throw new IndexOutOfRangeException("Index is out of range of List");
            }
            Node newNode = new Node(d);
            Node current = Head;
            for (int i = 0; i < index - 1; i++)
            {
                current = current.next;
            }
            newNode.next = current.next;
            current.next = newNode;
            Count++;
        }

        public void Prepend(int d)
        {
            if(Head == null)
            {
                Head = new Node(d);
                Count++;
            }
            else
            {
                Node newNode = new Node(d);
                newNode.next = Head;
                Head = newNode;
                Count++;
            }
        }

        public void PrintList()
        {
            Node current = Head;
            while(current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
            Console.WriteLine("Count is: " + Count);
        }
    }

    public class Node
    {
        public Node next { get; set; }
        public int data { get; set; }

        public Node(int d)
        {
            data = d;
        }
    }
}
