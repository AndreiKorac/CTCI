using NUnit.Framework;
using DSA;
using System;

namespace DSATests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void InsertStart_InsertsAtStart_HeadValueCorrect()
        {
            LinkedList list = new LinkedList();
            list.InsertLast(5);
            list.InsertLast(4);
            list.InsertStart(13);
            list.InsertLast(5);
            list.InsertStart(20);
            list.InsertAfter(13, 0);

            int headValue = list.Head.Value;

            Assert.AreEqual(20, headValue);
        }

        [Test]
        public void RemoveFirst_RemovesFirstNode_HeadUpdated()
        {
            LinkedList list = new LinkedList();
            list.InsertLast(5);
            list.InsertLast(4);
            list.InsertLast(9);
            list.InsertLast(13);

            Node expectedUpdatedHead = list.Head.Next;

            list.RemoveFirst();

            Assert.AreEqual(expectedUpdatedHead, list.Head);

            Assert.AreEqual(3, list.Count);
        }

        [Test]
        public void RemoveFirst_SingleElementList_NoNodes()
        {
            LinkedList list = new LinkedList();
            list.InsertLast(5);

            list.RemoveFirst();

            Assert.AreEqual(null, list.Head);
            Assert.AreEqual(0, list.Count);
        }

        [Test]
        public void RemoveFirst_EmptyList_ThrowsException()
        {
            LinkedList list = new LinkedList();

            Assert.Throws<InvalidOperationException>(() => list.RemoveFirst());
        }

        [Test]
        public void RemoveLast_SingleElementList_NoNodes()
        {
            LinkedList list = new LinkedList();
            list.InsertLast(5);

            list.RemoveLast();

            Assert.AreEqual(null, list.Head);
            Assert.AreEqual(0, list.Count);
        }

        [Test]
        public void RemoveLast_EmptyList_ThrowsException()
        {
            LinkedList list = new LinkedList();

            Assert.Throws<InvalidOperationException>(() => list.RemoveLast());
        }

        [Test]
        public void RemoveLast_RemovesLastNode_LastNodeUpdated()
        {
            LinkedList list = new LinkedList();
            list.InsertLast(5);
            list.InsertLast(4);
            list.InsertLast(9);
            list.InsertLast(13);

            int valueAtLastNode = list.ValueAt(2);

            list.RemoveLast();

            Assert.AreEqual(9, valueAtLastNode);
            Assert.AreEqual(3, list.Count);
        }

        [Test]
        public void Contains_ContainedValue_ReturnTrue()
        {
            LinkedList list = new LinkedList();
            list.InsertLast(5);
            list.InsertLast(1);
            list.InsertLast(3);

            bool hasValue = list.Contains(3);

            Assert.True(hasValue);
        }

        [Test]
        public void Contains_UncontainedValue_ReturnFalse()
        {
            LinkedList list = new LinkedList();
            list.InsertLast(5);
            list.InsertLast(1);
            list.InsertLast(3);

            bool hasValue = list.Contains(8);

            Assert.False(hasValue);
        }

        [Test]
        public void ValueAt_ValueAtIndex_ReturnValue()
        {
            LinkedList list = new LinkedList();
            list.InsertLast(5);
            list.InsertLast(1);
            list.InsertLast(3);

            int value = list.ValueAt(2);

            Assert.AreEqual(3, value);
        }



        [Test]
        public void ValueAt_ValueAtOutOfRangeIndex_ThrowsException()
        {
            LinkedList list = new LinkedList();
            list.InsertLast(5);
            list.InsertLast(1);
            list.InsertLast(3);

            Assert.Throws<IndexOutOfRangeException>(() => list.ValueAt(3));
        }
    }
}