using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparation.BinaryTree
{
    public class BinSearchTreeDetector<T> where T : IComparable<T>
    {
        /* 4.5 - Implement a function to check if a binary tree is a binary search tree.
         * --------
         * First thought was In-order traversal, and then check the result array to see if
         * it's sorted.  Book says there is a way to do this without the external array via recursion.
         * Then I read Min/Max as a hint, and it showed a tree that violated that ALL left nodes must be
         * less then current.
         * 
         * That easily turned into the idea to pass min and max down the recursion stack, change min max
         * accoringly at each depth.  A good exersice in passing data down the recursion stack.
         * */

        public static bool IsBinarySearchTree(Node<T> root, T min, T max)
        {
            return Traverse(root, min, max);
        }

        private static bool Traverse(Node<T> node, T min, T max)
        {
            // min <= node.data < max
            if (!(min.CompareTo(node.data) <= 0 && node.data.CompareTo(max) < 0 ))
            {
                return false;
            }

            if (node.left != null)
            {
                if (!Traverse(node.left, min, node.data))
                {
                    return false;
                }
            }

            if (node.right != null)
            {
                if (!Traverse(node.right, node.data, max))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
