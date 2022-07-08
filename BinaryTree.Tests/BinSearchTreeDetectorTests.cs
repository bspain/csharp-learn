using System;
using InterviewPreparation.BinaryTree;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.BinaryTree
{
    [TestClass]
    public class BinSearchTreeDetectorTests
    {
        [TestMethod]
        public void BinDetect_Base0()
        {
            Node<int> root = new Node<int>(0);

            Assert.IsTrue(BinSearchTreeDetector<int>.IsBinarySearchTree(root, 0, 100));
        }

        [TestMethod]
        public void BinDetect_MinViolation()
        {
            Node<int> root = new Node<int>(0);

            Assert.IsFalse(BinSearchTreeDetector<int>.IsBinarySearchTree(root, 1, 10));
        }

        [TestMethod]
        public void BinDetect_MaxViolation()
        {
            Node<int> root = new Node<int>(10);

            Assert.IsFalse(BinSearchTreeDetector<int>.IsBinarySearchTree(root, 0, 10));
        }

        [TestMethod]
        public void BinDetect_PassCase0()
        {
            Node<int> root = new Node<int>(2);
            root.left = new Node<int>(1);

            Assert.IsTrue(BinSearchTreeDetector<int>.IsBinarySearchTree(root, 0, 100));

            root.right = new Node<int>(3);

            Assert.IsTrue(BinSearchTreeDetector<int>.IsBinarySearchTree(root, 0, 100));
        }

        [TestMethod]
        public void BinDetect_FailCase0()
        {
            Node<int> root = new Node<int>(2);
            root.left = new Node<int>(3);

            Assert.IsFalse(BinSearchTreeDetector<int>.IsBinarySearchTree(root, 0, 100));
        }

        [TestMethod]
        public void BinDetect_FailCase1()
        {
            Node<int> root = new Node<int>(2);
            root.right = new Node<int>(1);

            Assert.IsFalse(BinSearchTreeDetector<int>.IsBinarySearchTree(root, 0, 100));
        }

        [TestMethod]
        public void BinDetect_FailCase2()
        {
            Node<int> root = new Node<int>(2);
            root.left = new Node<int>(3);
            root.right = new Node<int>(1);

            Assert.IsFalse(BinSearchTreeDetector<int>.IsBinarySearchTree(root, 0, 100));
        }

        [TestMethod]
        public void BinDetect_FailCase_LeftViolation()
        {
            Node<int> root = new Node<int>(20);
            root.left = new Node<int>(10);
            root.right = new Node<int>(30);
            root.left.right = new Node<int>(25);

            Assert.IsFalse(BinSearchTreeDetector<int>.IsBinarySearchTree(root, 0, 100));
        }

        [TestMethod]
        public void BinDetect_FailCase_RightViolation()
        {
            Node<int> root = new Node<int>(20);
            root.left = new Node<int>(10);
            root.right = new Node<int>(30);
            root.right.left = new Node<int>(15);

            Assert.IsFalse(BinSearchTreeDetector<int>.IsBinarySearchTree(root, 0, 100));
        }

        [TestMethod]
        public void BinDetect_PassCase_Depth2()
        {
            Node<int> root = new Node<int>(20);
            root.left = new Node<int>(10);
            root.left.right = new Node<int>(15);
            root.right = new Node<int>(30);
            root.right.left = new Node<int>(25);

            Assert.IsTrue(BinSearchTreeDetector<int>.IsBinarySearchTree(root, 0, 100));
        }
    }
}
