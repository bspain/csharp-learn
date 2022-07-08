using System;
using InterviewPreparation.StacksAndQueues;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.StacksAndQueues
{
    [TestClass]
    public class QueueWithStacksTests
    {
        [TestMethod]
        public void QueuesWithStacks_TestBase()
        {
            var queue = new QueueUsingStacks<int>();

            queue.Enqueue(1);
            queue.Enqueue(2);

            Assert.AreEqual(1, queue.Dequeue());
            Assert.AreEqual(2, queue.Dequeue());
        }

        [TestMethod]
        public void QueuesWithStacks_TestBase2()
        {
            var queue = new QueueUsingStacks<int>();

            queue.Enqueue(1);
            queue.Enqueue(2);

            Assert.AreEqual(1, queue.Dequeue());

            queue.Enqueue(3);
            Assert.AreEqual(2, queue.Dequeue());
            Assert.AreEqual(3, queue.Dequeue());
        }
    }
}
