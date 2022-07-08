using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparation.BinaryTree
{
    public class DepthFinder<T> where T : IComparable<T>
    {
        /* 4.1 - Implement a function to check if a binary tree is balanced.  For the purposes of this question, a balanced tree is defined
         * to be a tree such that the heights of the two subtrees of any node never differ by more then one.
         * -----
         * Done this before, so I instinctively knew that the key was a depth method that returned both balance at that depth, and depth.
         * Book says to use -1 as a return value for depth, I went with out variables to make it more explicit... although maybe more cumbersome
         * to work with.  Initially, I forgot to check the balanced out at each node in the tree.
         * 
         * Same recursive idealogy, get to the bottom first, and then work out your conditions for success.  Had to consider depth though, the recursive
         * bottom can only day if depth is 0 or not, never it's value, so the caller is reponsible for this (e.g. childDepth = 1 + childDepth(n.child))
         */

        private Node<T> root;

        public DepthFinder(Node<T> root)
        {
            this.root = root;
        }

        public bool IsTreeBalanced()
        {
            bool balanced;
            int depth;
            this.GetDepthAndBalanceOf(this.root, out balanced, out depth);

            return balanced;
        }

        private void GetDepthAndBalanceOf(Node<T> node, out bool balanced, out int depth)
        {
            depth = 0;

            if (node.left == null && node.right == null)
            {
                balanced = true;
                return;
            }

            int leftDepth = 0;
            bool leftBalanced = true;

            if (node.left != null)
            {
                int leftChildDepth;
                GetDepthAndBalanceOf(node.left, out leftBalanced, out leftChildDepth);
                leftDepth = 1 + leftChildDepth;
            }

            int rightDepth = 0;
            bool rightBalance = true;

            if (node.right != null)
            {
                int rightChildDepth;
                GetDepthAndBalanceOf(node.right, out rightBalance, out rightChildDepth);
                rightDepth = 1 + rightChildDepth;
            }

            if (!leftBalanced || !rightBalance)
            {
                balanced = false;
                return;
            }

            depth = (leftDepth > rightDepth) ? leftDepth : rightDepth;
            if (Math.Abs(leftDepth - rightDepth) > 1)
            {
                balanced = false;                
            }
            else
            {
                balanced = true;
            }

            return;
        }


    }
}
