using System;
using InterviewPreparation.BinaryTree;
using LL = InterviewPreparation.LinkedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.BinaryTree
{
    [TestClass]
    public class LinkDepthNodeTests
    {
        [TestMethod]
        public void LinkDepthNode_Base0()
        {
            Node<int> root = new Node<int>(0);
            var listOfLL = LinkDepthNodes<int>.CreateDepthLists(root);

            Assert.AreEqual(1, listOfLL.Count);

            var ll0 = LL.ListHelper.Build(new int[] { 0 });

            Assert.IsTrue(LL.ListHelper.AreEqual(ll0, listOfLL[0]));
        }

        [TestMethod]
        public void LinkDepthNode_Base1()
        {
            Node<int> root = new Node<int>(0);
            root.left = new Node<int>(1);
            root.right = new Node<int>(2);

            var listOfLL = LinkDepthNodes<int>.CreateDepthLists(root);

            Assert.AreEqual(2, listOfLL.Count);

            var ll0 = LL.ListHelper.Build(new int[] { 0 });
            var ll1 = LL.ListHelper.Build(new int[] { 1, 2 });

            Assert.IsTrue(LL.ListHelper.AreEqual(ll0, listOfLL[0]));
            Assert.IsTrue(LL.ListHelper.AreEqual(ll1, listOfLL[1]));
        }

        [TestMethod]
        public void LinkDepthNode_Base2()
        {
            Node<int> root = new Node<int>(0);
            root.left = new Node<int>(1);
            root.right = new Node<int>(2);
            root.left.left = new Node<int>(3);
            root.right.left = new Node<int>(5);

            var listOfLL = LinkDepthNodes<int>.CreateDepthLists(root);

            Assert.AreEqual(3, listOfLL.Count);

            var ll0 = LL.ListHelper.Build(new int[] { 0 });
            var ll1 = LL.ListHelper.Build(new int[] { 1, 2 });
            var ll2 = LL.ListHelper.Build(new int[] { 3, 5 });

            Assert.IsTrue(LL.ListHelper.AreEqual(ll0, listOfLL[0]));
            Assert.IsTrue(LL.ListHelper.AreEqual(ll1, listOfLL[1]));
            Assert.IsTrue(LL.ListHelper.AreEqual(ll2, listOfLL[2]));

            // Fill out tree
            root.left.right = new Node<int>(4);
            root.right.right = new Node<int>(6);

            var ll2b = LL.ListHelper.Build(new int[] { 3, 4, 5, 6 });
            listOfLL = LinkDepthNodes<int>.CreateDepthLists(root);
            Assert.IsTrue(LL.ListHelper.AreEqual(ll2b, listOfLL[2]));
        }

        [TestMethod]
        public void LinkDepthNode_Disjoint()
        {
            Node<int> root = new Node<int>(0);
            root.left = new Node<int>(1);
            root.right = new Node<int>(2);
            root.left.left = new Node<int>(3);
            root.left.left.left = new Node<int>(7);
            root.right.left = new Node<int>(5);            

            var listOfLL = LinkDepthNodes<int>.CreateDepthLists(root);

            Assert.AreEqual(4, listOfLL.Count);

            var ll0 = LL.ListHelper.Build(new int[] { 0 });
            var ll1 = LL.ListHelper.Build(new int[] { 1, 2 });
            var ll2 = LL.ListHelper.Build(new int[] { 3, 5 });
            var ll3 = LL.ListHelper.Build(new int[] { 7 });

            Assert.IsTrue(LL.ListHelper.AreEqual(ll0, listOfLL[0]));
            Assert.IsTrue(LL.ListHelper.AreEqual(ll1, listOfLL[1]));
            Assert.IsTrue(LL.ListHelper.AreEqual(ll2, listOfLL[2]));
            Assert.IsTrue(LL.ListHelper.AreEqual(ll3, listOfLL[3]));
        }

    }
}
