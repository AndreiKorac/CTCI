using NUnit.Framework;
using DSA;
using System;

namespace DSATests
{
    public class StackTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Push_CheckPushed_EqualsPushedValue()
        {
            Stack stack = new Stack();
            stack.Push(5);

            int topValue = stack.Pop();

            Assert.AreEqual(5, topValue);
        }

        [Test]
        public void PushSeveral_CheckTop_EqualsTopValue()
        {
            Stack stack = new Stack();
            stack.Push(5);
            stack.Push(10);
            stack.Push(6);

            int topValue = stack.Pop();

            Assert.AreEqual(6, topValue);
        }

        [Test]
        public void Pop_GetPopped_EqualsPoppedValue()
        {
            Stack stack = new Stack();
            stack.Push(5);
            stack.Push(10);
            stack.Push(6);

            int poppedValue = stack.Pop();

            Assert.AreEqual(6, poppedValue);
        }

        [Test]
        public void Pop_EmptyStack_ThrowsException()
        {
            Stack stack = new Stack();

            Assert.Throws<InvalidOperationException>(() => stack.Pop());
        }

        [Test]
        public void Peek_EmptyStack_ThrowsException()
        {
            Stack stack = new Stack();

            Assert.Throws<InvalidOperationException>(() => stack.Peek());
        }

        [Test]
        public void Peek_SingleElementStack_ReturnsElement()
        {
            Stack stack = new Stack();
            stack.Push(10);

            int topValue = stack.Peek();

            Assert.AreEqual(10, topValue);
        }

        [Test]
        public void Peek_SeveralElementStack_ReturnsCorrectTopElement()
        {
            Stack stack = new Stack();
            stack.Push(10);
            stack.Push(15);
            stack.Push(4);

            int topValue = stack.Peek();

            Assert.AreEqual(4, topValue);
        }

        [Test]
        public void IsEmpty_EmptyStack_ReturnsTrue()
        {
            Stack stack = new Stack();

            bool isEmpty = stack.IsEmpty();

            Assert.IsTrue(isEmpty);
        }

        [Test]
        public void IsEmpty_NonEmptyStack_ReturnsFalse()
        {
            Stack stack = new Stack();
            stack.Push(5);

            bool isEmpty = stack.IsEmpty();

            Assert.IsFalse(isEmpty);
        }
    }
}
