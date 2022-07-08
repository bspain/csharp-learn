using System;
using InterviewPreparation.BinaryTree;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.BinaryTree
{
    [TestClass]
    public class CommonAncestorTests
    {
        [TestMethod]
        public void CommonAncestor_Base()
        {
            var ca = new CommonAncestor<int>(new Node<int>(0));

            Assert.IsNull(ca.Find(1, 2));
            Assert.IsNull(ca.Find(0, 2));
            Assert.IsNull(ca.Find(1, 0));
        }

        [TestMethod]
        public void CommonAncestor_ValuesRootAndDirectChild()
        {
            Node<int> root = new Node<int>(0);
            root.left = new Node<int>(1);
            root.right = new Node<int>(2);
            var ca = new CommonAncestor<int>(root);

            Assert.AreEqual(0, ca.Find(0, 1).data);
            Assert.AreEqual(0, ca.Find(0, 2).data);
        }

        [TestMethod]
        public void CommonAncestor_ValuesDirectChildOfRoot()
        {
            Node<int> root = new Node<int>(0);
            root.left = new Node<int>(1);
            root.right = new Node<int>(2);
            var ca = new CommonAncestor<int>(root);

            Assert.AreEqual(0, ca.Find(1, 2).data);
        }

        [TestMethod]
        public void CommonAncestor_ValuesLeftRightSubTreeOfRoot()
        {
            Node<int> root = new Node<int>(3);
            root.left = new Node<int>(2);
            root.left.left = new Node<int>(1);
            root.right = new Node<int>(4);
            root.right.right = new Node<int>(5);

            var ca = new CommonAncestor<int>(root);

            Assert.AreEqual(3, ca.Find(2, 4).data);
            Assert.AreEqual(3, ca.Find(2, 5).data);
            Assert.AreEqual(3, ca.Find(4, 1).data);
            Assert.AreEqual(3, ca.Find(1, 5).data);
        }

        [TestMethod]
        public void CommonAncestor_ValuesRootAndDeepSubTree()
        {
            Node<int> root = new Node<int>(3);
            root.left = new Node<int>(2);
            root.left.left = new Node<int>(1);
            root.right = new Node<int>(4);
            root.right.right = new Node<int>(5);

            var ca = new CommonAncestor<int>(root);

            Assert.AreEqual(3, ca.Find(3, 5).data);
            Assert.AreEqual(3, ca.Find(3, 1).data);
        }

        [TestMethod]
        public void CommonAncestor_ValuesChildOfLeftRightSubTree()
        {
            Node<int> root = new Node<int>(3);
            root.left = new Node<int>(2);
            root.left.left = new Node<int>(1);
            root.right = new Node<int>(4);
            root.right.right = new Node<int>(5);

            var ca = new CommonAncestor<int>(root);

            Assert.AreEqual(2, ca.Find(2, 1).data);
            Assert.AreEqual(4, ca.Find(4, 5).data);
        }

        [TestMethod]
        public void CommonAncestor_ThreeDepthValidation()
        {
            /*          4
             *       3     6
             *     1   2  5  7
             *     */

            Node<int> root = new Node<int>(4);
            root.left = new Node<int>(3);
            root.left.left = new Node<int>(1);
            root.left.right = new Node<int>(2);
            root.right = new Node<int>(6);
            root.right.left = new Node<int>(5);
            root.right.right = new Node<int>(7);

            var ca = new CommonAncestor<int>(root);

            Assert.AreEqual(4, ca.Find(3, 6).data);
            Assert.AreEqual(4, ca.Find(1, 5).data);
            Assert.AreEqual(4, ca.Find(2, 7).data);

            Assert.AreEqual(4, ca.Find(3, 5).data);
            Assert.AreEqual(4, ca.Find(3, 7).data);

            Assert.AreEqual(4, ca.Find(6, 1).data);
            Assert.AreEqual(4, ca.Find(6, 2).data);

            Assert.AreEqual(3, ca.Find(1, 2).data);
            Assert.AreEqual(6, ca.Find(5, 7).data);
        }

    }
}
