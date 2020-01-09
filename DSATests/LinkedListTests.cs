using NUnit.Framework;
using DSA;

namespace DSATests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void LinkedListContains_ContainedValue_ReturnTrue()
        {
            LinkedList list = new LinkedList();
            list.Append(5);
            list.Append(1);
            list.Append(3);

            bool hasValue = list.Contains(3);

            Assert.True(hasValue);
        }

        [Test]
        public void LinkedListContains_UncontainedValue_ReturnFalse()
        {
            LinkedList list = new LinkedList();
            list.Append(5);
            list.Append(1);
            list.Append(3);

            bool hasValue = list.Contains(8);

            Assert.False(hasValue);
        }
    }
}