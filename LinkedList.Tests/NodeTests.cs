using System;
using InterviewPreparation.LinkedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.LinkedList
{
    [TestClass]
    public class NodeTests
    {
        [TestMethod]
        public void LinkedList_TestNodeLessThan()
        {
            Node<int> a = new Node<int>(1);
            Node<int> b = new Node<int>(2);

            Assert.IsTrue(a.IsLessThan(b));
            Assert.IsFalse(b.IsLessThan(a));
        }

        [TestMethod]
        public void LinkedList_TestNodeEqualTo()
        {
            Node<int> a = new Node<int>(1);
            Node<int> b = new Node<int>(1);

            Assert.IsTrue(a.IsEqualTo(b));
            Assert.IsFalse(a.IsLessThan(b));
            Assert.IsFalse(b.IsLessThan(a));
        }

        [TestMethod]
        public void LinkedList_EqualLists()
        {
            Node<int> a = ListHelper.Build(new int[] { 1, 2, 3 });
            Node<int> b = ListHelper.Build(new int[] { 1, 2, 3 });

            Assert.IsTrue(ListHelper.AreEqual(a, b));
        }

        [TestMethod]
        public void LinkedList_NotEqualLists_Values()
        {
            Node<int> a = ListHelper.Build(new int[] { 1, 2, 3 });
            Node<int> b = ListHelper.Build(new int[] { 1, 2, 4 });

            Assert.IsFalse(ListHelper.AreEqual(a, b));
        }

        [TestMethod]
        public void LinkedList_NotEqualLists_Length()
        {
            Node<int> a = ListHelper.Build(new int[] { 1, 2, 3 });
            Node<int> b = ListHelper.Build(new int[] { 1, 2, 3, 4 });

            Assert.IsFalse(ListHelper.AreEqual(a, b));
            Assert.IsFalse(ListHelper.AreEqual(b, a));

        }

    }
}
