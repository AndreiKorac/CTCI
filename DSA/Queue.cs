using System;

namespace DSA
{
    public class Queue
    {
        private QueueElement First { get; set; }
        private QueueElement Last { get; set; }
        public int Count { get; set; }

        public void Enqueue(int value)
        {
            QueueElement newElement = new QueueElement(value);
            if (First == null)
            {
                First = newElement;
                Last = newElement;
            }
            else
            {
                newElement.NextElement = Last;
                Last.PreviousElement = newElement;
                Last = newElement;
            }
            Count++;
        }

        public int Dequeue()
        {
            if (First == null) throw new InvalidOperationException("Queue is empty");
            int valueToDequeue = First.Value;
            First = First.PreviousElement;

            Count--;
            return valueToDequeue;
        }

        public int PeekFirst()
        {
            if (First == null) throw new InvalidOperationException("Queue is empty");
            return First.Value;
        }

        public int PeekLast()
        {
            if (First == null) throw new InvalidOperationException("Queue is empty");
            return Last.Value;
        }

        public bool IsEmpty()
        {
            return First == null;
        }


        private class QueueElement
        {
            public int Value { get; set; }
            public QueueElement NextElement { get; set; }
            public QueueElement PreviousElement { get; set; }



            public QueueElement(int value)
            {
                Value = value;
            }
        }
    }
}
