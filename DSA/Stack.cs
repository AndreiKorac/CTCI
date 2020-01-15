using System;
using System.Collections.Generic;
using System.Text;

namespace DSA
{
    public class Stack
    {
        private StackElement Top { get; set; }
        public int Count { get; set; }

        public void Push(int value)
        {
            StackElement stackElement = new StackElement(value);
            stackElement.NextElement = Top;
            Top = stackElement;
            Count++;
        }

        public int Pop()
        {
            if (Top == null) throw new InvalidOperationException("Stack is Empty");
            int topValue = Top.Value;
            Top = Top.NextElement;
            Count--;

            return topValue;
        }

        public int Peek()
        {
            if (Top == null) throw new InvalidOperationException("Stack is empty");
            return Top.Value;
        }

        public bool IsEmpty()
        {
            return Top == null;
        }

        private class StackElement
        {
            public int Value { get; set; }
            public StackElement NextElement { get; set; }

            public StackElement(int value)
            {
                Value = value;
            }
        }
    }
}
