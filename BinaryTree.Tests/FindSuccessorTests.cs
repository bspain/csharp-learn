using System;
using InterviewPreparation.BinaryTree;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.BinaryTree
{
    [TestClass]
    public class FindSuccessorTests
    {
        public static Node<int> Build(int data, Node<int> parent)
        {
            Node<int> node = new Node<int>(data);
            node.tag = parent;
            return node;
        }

        [TestMethod]
        public void FindSuccessor_RootCase()
        {
            Node<int> root = new Node<int>(0);

            Assert.IsNull(FindInOrderSuccessor<int>.Search(root));
        }


        [TestMethod]
        public void FindSuccessor_BaseBalanced()
        {
            Node<int> root = new Node<int>(2);
            root.left = Build(1, root);
            root.right = Build(3, root);

            Assert.AreEqual(2, FindInOrderSuccessor<int>.Search(root.left).data);
            Assert.AreEqual(3, FindInOrderSuccessor<int>.Search(root).data);
            Assert.IsNull(FindInOrderSuccessor<int>.Search(root.right));
        }

        [TestMethod]
        public void FindSuccessor_Depth2Balanced()
        {
            Node<int> root = new Node<int>(4);

            root.left = Build(2, root);
            root.left.left = Build(1, root.left);
            root.left.right = Build(3, root.left);

            root.right = Build(6, root);
            root.right.left = Build(5, root.right);
            root.right.right = Build(7, root.right);

            Assert.AreEqual(2, FindInOrderSuccessor<int>.Search(root.left.left).data);
            Assert.AreEqual(3, FindInOrderSuccessor<int>.Search(root.left).data);
            Assert.AreEqual(4, FindInOrderSuccessor<int>.Search(root.left.right).data);
            Assert.AreEqual(5, FindInOrderSuccessor<int>.Search(root).data);
            Assert.AreEqual(6, FindInOrderSuccessor<int>.Search(root.right.left).data);
            Assert.AreEqual(7, FindInOrderSuccessor<int>.Search(root.right).data);
            Assert.IsNull(FindInOrderSuccessor<int>.Search(root.right.right));
        }

        [TestMethod]
        public void FindSuccessor_DeepLeft()
        {
            /*        6
             *    4
             *  2   5
             * 1 3
             * */

            Node<int> root = new Node<int>(6);
            root.left = Build(4, root);
            root.left.right = Build(5, root.left);
            root.left.left = Build(2, root.left);
            root.left.left.right = Build(3, root.left.left);
            root.left.left.left = Build(1, root.left.left);

            Assert.AreEqual(2, FindInOrderSuccessor<int>.Search(root.left.left.left).data);
            Assert.AreEqual(3, FindInOrderSuccessor<int>.Search(root.left.left).data);
            Assert.AreEqual(4, FindInOrderSuccessor<int>.Search(root.left.left.right).data);
            Assert.AreEqual(5, FindInOrderSuccessor<int>.Search(root.left).data);
            Assert.AreEqual(6, FindInOrderSuccessor<int>.Search(root.left.right).data);
            Assert.IsNull(FindInOrderSuccessor<int>.Search(root));
        }

        [TestMethod]
        public void FindSuccessor_DeepRight()
        {
            /*  1
             *      3
             *    2    5
             *        4  6
             **/

            Node<int> root = new Node<int>(1);
            root.right = Build(3, root);
            root.right.left = Build(2, root.right);
            root.right.right = Build(5, root.right);
            root.right.right.left = Build(4, root.right.right);
            root.right.right.right = Build(6, root.right.right);

            Assert.AreEqual(2, FindInOrderSuccessor<int>.Search(root).data);
            Assert.AreEqual(3, FindInOrderSuccessor<int>.Search(root.right.left).data);
            Assert.AreEqual(4, FindInOrderSuccessor<int>.Search(root.right).data);
            Assert.AreEqual(5, FindInOrderSuccessor<int>.Search(root.right.right.left).data);
            Assert.AreEqual(6, FindInOrderSuccessor<int>.Search(root.right.right).data);
            Assert.IsNull(FindInOrderSuccessor<int>.Search(root.right.right.right));
        }

    }
}
