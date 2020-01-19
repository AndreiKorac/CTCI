using DSA;
using System;
using System.Collections.Generic;
using System.Text;

namespace CTCISolutions
{
    public class ChapterThree
    {
        public Stack SortStack(Stack input)
        {
            Stack tempStack = new Stack();

            while(input.Count > 0)
            {
                int temp = input.Pop();
                while(tempStack.Count > 0 && tempStack.Peek() > temp)
                {
                    input.Push(tempStack.Pop());
                }
                tempStack.Push(temp);
            }
            while(tempStack.Count > 0)
            {
                input.Push(tempStack.Pop());
            }
            return input;
        }
    }
}
