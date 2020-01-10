using CTCISolutions;
using NUnit.Framework;
using DSA;

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

            listWithDups = _testHelper.RemoveDups(listWithDups);

            for (int i = 0; i < listWithoutDups.Count - 1; i++)
            {
                Assert.AreEqual(listWithDups.ValueAt(i), listWithoutDups.ValueAt(i));
            }
            Assert.AreEqual(4, listWithoutDups.Count);
        }

        #endregion
    }
}