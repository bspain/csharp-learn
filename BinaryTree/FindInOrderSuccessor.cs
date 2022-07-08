using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparation.BinaryTree
{
    public static class FindInOrderSuccessor<T> where T : IComparable<T>
    {
        /* 4.6 - Write an algorithm to find the 'next' node (i.e. the in-order successor)
         * of a given node in a binary search tree.  You may assume that each node has a
         * link to it's parent.
         * -------
         * Getting good at thinking about recursive solutions by now.  Broken down
         * into two pieces (1. knowing that if the node has a right child, I need the smallest
         * of it's subtree.  2.  Rationalizing that if we go to the parent, we need
         * the first parent where we are it's left child)
         * 
         * Second piece I implemented without issue, the first piece I actually got wrong
         * and didn't realize until tests exposed it.   (Run some test data manually first)
         * */

        public static Node<T> Search(Node<T> root)
        {
            // Smallest of right subtree first
            if (root.right != null)
            {
                return FindSmallest(root.right);
            }

            // Next highest successor, or null.
            return FindNextHighestSuccessor(root);
        }

        private static Node<T> FindSmallest(Node<T> node)
        {
            if (node.left == null && node.right == null)
            {
                return node;
            }

            if (node.left != null)
            {
                return FindSmallest(node.left);
            }

            return FindSmallest(node.right);
        }

        private static Node<T> FindNextHighestSuccessor(Node<T> node)
        {
            if (node.tag == null)
            {
                return null; // Fail
            }
            else
            {
                if (((Node<T>)node.tag).left != null &&
                    ((Node<T>)node.tag).left.data.CompareTo(node.data) == 0)
                {
                    return (Node<T>)node.tag;
                }
                else
                {
                    return FindNextHighestSuccessor((Node<T>)node.tag);
                }
            }
        }
    }
}
