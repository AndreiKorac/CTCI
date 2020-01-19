using NUnit.Framework;
using DSA;
using System;

namespace DSATests
{
    public class SetOfStacksTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Push_EmptyStack_PushesElement()
        {
            SetOfStacks stack = new SetOfStacks();
            stack.Push(10);

            int element = stack.Peek();

            Assert.AreEqual(10, element);
        }

        [Test]
        public void Push_StackAtMax_PushesToNewStack()
        {
            //Test the creation of a new internal stack
            //Insert ten items (max is set to 10), then insert an eleventh
            //Checks that the 10th and 11th values are both correct
            SetOfStacks stacks = new SetOfStacks();
            for (int i = 0; i < 10; i++)
            {
                stacks.Push(i);
            }
            int lastValue = stacks.Peek();

            stacks.Push(15);

            int lastValueOnNewStack = stacks.Peek();

            Assert.AreEqual(9, lastValue);
            Assert.AreEqual(15, lastValueOnNewStack);
        }
    }
}
