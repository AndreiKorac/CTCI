using CTCISolutions;
using NUnit.Framework;
using DSA;
using System;
namespace SolutionsTests
{
    public class ChapterThreeTests
    {
        private ChapterThree _testHelper;

        public ChapterThreeTests()
        {
            _testHelper = new ChapterThree();
        }

        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void SortStack_SortsGivenStack()
        {
            Stack stack = new Stack();
            stack.Push(5);
            stack.Push(3);
            stack.Push(7);
            stack.Push(11);
            stack.Push(4);

            Stack sortedStack = new Stack();
            sortedStack.Push(11);
            sortedStack.Push(7);
            sortedStack.Push(5);
            sortedStack.Push(4);
            sortedStack.Push(3);

            stack = _testHelper.SortStack(stack);

            for (int i = 0; i < sortedStack.Count; i++)
            {
                Assert.AreEqual(sortedStack.Pop(), stack.Pop());
            }
        }
    }
}
