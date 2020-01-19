using System;
using System.Collections.Generic;
using System.Text;

namespace DSA
{
    public class SetOfStacks
    {
        private List<Stack> stacks { get; set; }
        private int stackMax { get; set; }

        public SetOfStacks()
        {
            stacks = new List<Stack>();
            stackMax = 10;
        }

        public void Push(int value)
        {
            if (stacks.Count == 0)
            {
                CreateNewStackAndPush(value);
            }
            else
            {
                if(stacks[stacks.Count - 1].Count >= stackMax)
                {
                    CreateNewStackAndPush(value);
                }
                else
                {
                    stacks[stacks.Count - 1].Push(value);
                }
            }
        }

        public int Pop()
        {
            if (stacks == null) throw new InvalidOperationException("Stack is empty");

            Stack lastStack = stacks[stacks.Count - 1];
            if (lastStack == null) throw new InvalidOperationException("Stack is empty");

            int value = lastStack.Pop();
            if (lastStack.Count == 0)
                stacks.RemoveAt(stacks.Count - 1);
            return value;

        }

        public int Peek()
        {
            if (stacks == null) throw new InvalidOperationException("Stack is empty");

            Stack lastStack = stacks[stacks.Count - 1];
            if (lastStack == null) throw new InvalidOperationException("Stack is empty");

            return lastStack.Peek();
        }

        private void CreateNewStackAndPush(int value)
        {
            Stack newStack = new Stack();
            newStack.Push(value);

            stacks.Add(newStack);
        }
    }
}
