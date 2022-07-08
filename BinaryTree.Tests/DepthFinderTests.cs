using System;
using InterviewPreparation.BinaryTree;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.BinaryTree
{
    [TestClass]
    public class DepthFinderTests
    {
        [TestMethod]
        public void DepthFinder_Base0()
        {
            DepthFinder<int> df = new DepthFinder<int>(new Node<int>(5));

            Assert.IsTrue(df.IsTreeBalanced());
        }

        [TestMethod]
        public void DepthFinder_LeftDepth1()
        {
            Node<int> root = new Node<int>(0);
            root.left = new Node<int>(1);
            DepthFinder<int> df = new DepthFinder<int>(root);

            Assert.IsTrue(df.IsTreeBalanced());
        }

        [TestMethod]
        public void DepthFinder_RightDepth1()
        {
            Node<int> root = new Node<int>(0);
            root.right = new Node<int>(1);
            DepthFinder<int> df = new DepthFinder<int>(root);

            Assert.IsTrue(df.IsTreeBalanced());
        }

        [TestMethod]
        public void DepthFinder_BothDepth1()
        {
            Node<int> root = new Node<int>(0);
            root.left = new Node<int>(1);
            root.right = new Node<int>(2);
            DepthFinder<int> df = new DepthFinder<int>(root);

            Assert.IsTrue(df.IsTreeBalanced());
        }

        [TestMethod]
        public void DepthFinder_LD2_RD1()
        {
            Node<int> root = new Node<int>(0);
            root.left = new Node<int>(1);
            root.left.left = new Node<int>(2);
            root.right = new Node<int>(3);

            DepthFinder<int> df = new DepthFinder<int>(root);

            Assert.IsTrue(df.IsTreeBalanced());
        }

        [TestMethod]
        public void DepthFinder_LD2a_RD1()
        {
            Node<int> root = new Node<int>(0);
            root.left = new Node<int>(1);
            root.left.right = new Node<int>(2);
            root.right = new Node<int>(3);

            DepthFinder<int> df = new DepthFinder<int>(root);

            Assert.IsTrue(df.IsTreeBalanced());
        }

        [TestMethod]
        public void DepthFinder_LD2_RD0()
        {
            Node<int> root = new Node<int>(0);
            root.left = new Node<int>(1);
            root.left.right = new Node<int>(2);

            DepthFinder<int> df = new DepthFinder<int>(root);

            Assert.IsFalse(df.IsTreeBalanced());
        }


        [TestMethod]
        public void DepthFinder_LD3_RD1()
        {
            Node<int> root = new Node<int>(0);
            root.left = new Node<int>(1);
            root.left.right = new Node<int>(2);
            root.left.right.left = new Node<int>(3);
            root.left.right.right = new Node<int>(4);

            root.right = new Node<int>(5);

            DepthFinder<int> df = new DepthFinder<int>(root);

            Assert.IsFalse(df.IsTreeBalanced());
        }

        [TestMethod]
        public void DepthFinder_LSubNotBalanced()
        {
            Node<int> root = new Node<int>(0);
            root.left = new Node<int>(1);
            root.right = new Node<int>(1);

            root.left.left = new Node<int>(2);
            root.left.right = new Node<int>(2);

            root.left.left.right = new Node<int>(3);

            root.left.left.right.right = new Node<int>(4);

            DepthFinder<int> df = new DepthFinder<int>(root);

            Assert.IsFalse(df.IsTreeBalanced());
        }

        [TestMethod]
        public void DepthFinder_RSubNotBalanced()
        {
            Node<int> root = new Node<int>(0);
            root.left = new Node<int>(1);
            root.right = new Node<int>(1);

            root.right.left = new Node<int>(2);
            root.right.right = new Node<int>(2);

            root.right.right.left = new Node<int>(3);

            root.right.right.left.right = new Node<int>(4);

            DepthFinder<int> df = new DepthFinder<int>(root);

            Assert.IsFalse(df.IsTreeBalanced());
        }
    }
}
