﻿using CTCISolutions;
using NUnit.Framework;
using DSA;
using System;

namespace SolutionsTests
{
    public class ChapterTwoTests
    {
        private ChapterTwo _testHelper;
        public ChapterTwoTests()
        {
            _testHelper = new ChapterTwo();
        }

        [SetUp]
        public void Setup()
        {

        }

        #region Remove Dups Tests

        [Test]
        public void RemoveDups_OneDuplicate_RemovesNode()
        {
            LinkedList listWithDups = new LinkedList();
            listWithDups.InsertLast(5);
            listWithDups.InsertLast(9);
            listWithDups.InsertLast(7);
            listWithDups.InsertLast(2);
            listWithDups.InsertLast(9);

            LinkedList listWithoutDups = new LinkedList();
            listWithoutDups.InsertLast(5);
            listWithoutDups.InsertLast(9);
            listWithoutDups.InsertLast(7);
            listWithoutDups.InsertLast(2);

            _testHelper.RemoveDupsWithDict(listWithDups);

            for (int i = 0; i < listWithoutDups.Count - 1; i++)
            {
                Assert.AreEqual(listWithDups.ValueAt(i), listWithoutDups.ValueAt(i));
            }
            Assert.AreEqual(4, listWithoutDups.Count);
        }

        [Test]
        public void KthToLast_KthInMiddle_ReturnsValue()
        {
            LinkedList list = new LinkedList();
            list.InsertLast(5);
            list.InsertLast(9);
            list.InsertLast(7);
            list.InsertLast(2);
            list.InsertLast(13);
            list.InsertLast(1);

            int valueAtK = _testHelper.KthToLast(list, 3);

            Assert.AreEqual(2, valueAtK);
        }

        [Test]
        public void KthToLast_KthIsLast_ReturnsLastElement()
        {
            LinkedList list = new LinkedList();
            list.InsertLast(5);
            list.InsertLast(9);
            list.InsertLast(7);
            list.InsertLast(2);
            list.InsertLast(13);
            list.InsertLast(16);

            int valueAtK = _testHelper.KthToLast(list, 1);

            Assert.AreEqual(16, valueAtK);
        }

        [Test]
        public void KthToLast_KthIsFirst_ReturnsFirstElement()
        {
            LinkedList list = new LinkedList();
            list.InsertLast(5);
            list.InsertLast(9);
            list.InsertLast(7);
            list.InsertLast(2);
            list.InsertLast(13);
            list.InsertLast(1);

            int valueAtK = _testHelper.KthToLast(list, 6);

            Assert.AreEqual(5, valueAtK);
        }

        [Test]
        public void KthToLast_KthOutOfRange_ThrowsException()
        {
            LinkedList list = new LinkedList();
            list.InsertLast(5);
            list.InsertLast(9);
            list.InsertLast(7);
            list.InsertLast(2);
            list.InsertLast(13);
            list.InsertLast(1);

            Assert.Throws<IndexOutOfRangeException>(() => _testHelper.KthToLast(list, 9));
        }

        [Test]
        public void RemoveMiddle_AMiddleNode_RemovesNode()
        {
            LinkedList list = new LinkedList();
            list.InsertLast(5);
            list.InsertLast(9);
            list.InsertLast(7);
            list.InsertLast(1);

            //Remove node with value 9
            _testHelper.RemoveMiddleNode(list.Head.Next);

            //If successful, new Head.Next should hold 7
            Assert.AreEqual(7, list.Head.Next.Value);
        }

        #endregion
    }
}