using NUnit.Framework;
using DSA;
using System;

namespace DSATests
{
    class QueueTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Enqueue_ToEmptyQueue_FirstAndLastUpdate()
        {
            Queue q = new Queue();
            q.Enqueue(10);

            int firstValue = q.PeekFirst();
            int lastValue = q.PeekLast();

            Assert.AreEqual(10, firstValue);
            Assert.AreEqual(10, lastValue);
        }

        [Test]
        public void Enqueue_ToPopulatedQueue_LastUpdated()
        {
            Queue q = new Queue();
            q.Enqueue(10);
            q.Enqueue(15);

            int lastValue = q.PeekLast();

            Assert.AreEqual(15, lastValue);
        }

        [Test]
        public void Dequeue_EmptyQueue_ThrowsException()
        {
            Queue q = new Queue();

            Assert.Throws<InvalidOperationException>(() => q.Dequeue());
        }

        [Test]
        public void Dequeue_Queue_UpdatesFirst()
        {
            Queue q = new Queue();
            q.Enqueue(10);
            q.Enqueue(15);
            q.Enqueue(9);

            int removedValue = q.Dequeue();

            Assert.AreEqual(10, removedValue);
            Assert.AreEqual(15, q.PeekFirst());
        }
    }
}
