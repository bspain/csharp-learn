using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparation.BinaryTree
{
    /* 4.7 - Design an algorithm and write code to find the first common ancestor of two
     * nodes in a binary tree.  Avoid storing additional nodes in a data structure.  NOTE:
     * This is not necessarily a binary search tree
     * ---------
     * Complex question, and I struggled a lot.  I first tried to push up state through the recrusion, but
     * that ended up getting me in alot of trouble.  It was easier when I switched to a class to maintain state
     * 
     * I recognized early that a solution that searches both left and right subtrees mulitple times for x and y was
     * a bad final solution, but in an interview, I think it makes sense to state that, and go with that solution first
     * (argue for solve, test, then optimize) - this solution worked, but it took too long and had too much logic to whiteboard
     * test.
     * 
     * Book proposes something similar, but takes advantage of this key fact:
     * 
     *  ** The Common Ancestor is the first node in the tree where x and y are in different subtrees. **
     *  
     *  As long as X and Y are in the same subtree, then go down, following X, until Y is in a separate
     *  subtree.
     *  
     * That solution is still multi-branch search, so the book recommends a recursive walk that analyzes the full
     * subtree
     *  commonAncestor(root, Node<int>(x), Node<int>(y))
     *      returns Node<int>(x) (if x in subtree and not y)
     *      returns Node<int>(y) (if y in subtree and not x)
     *      returns null if neither
     *      returns Node<int>(z) where z is the common ancestor
     *      
     * When commonAncestor(n.left, x, y) is non-null, and commonAncestor(n.right, x, y) is non-null, then commonAncestor has been
     * found.  Has bug however if the tree doesn't contain x or y.
     * */
    public class CommonAncestor<T> where T : IComparable<T>
    {
        T x;
        T y;
        bool foundX;
        bool foundY;
        Node<T> common;

        Node<T> root;

        public CommonAncestor(Node<T> root)
        {
            this.root = root;
        }


        public Node<T> Find(T x, T y)
        {
            this.x = x;
            this.y = y;
            this.foundX = false;
            this.foundY = false;
            this.common = null;

            this.TraverseForCommon(root);

            return common;
        }

        private void TraverseForCommon(Node<T> node)
        {
            if (common != null)
            {
                return;
            }

            if (!foundX && node.data.CompareTo(x) == 0)
            {
                foundX = true;
            }

            if (!foundY && node.data.CompareTo(y) == 0)
            {
                foundY = true;
            }

            if (foundX && foundY)
            {
                return;
            }

            if (!foundX && !foundY)
            {
                if (node.left != null)
                {
                    TraverseForCommon(node.left);

                    if (common != null)
                    {
                        return;
                    }
                }

                if (node.right != null && !foundX && !foundY)
                {
                    TraverseForCommon(node.right);

                    if (common != null)
                    {
                        return;
                    }
                }

                // If still haven't found X or Y traversing Left/Right
                // then return
                if (!foundX && !foundY)
                {
                    return;
                }
            }

            if (node.left != null)
            {
                if (!foundX && TraverseFor(node.left, x))
                {
                    foundX = true;
                }
                if (!foundY && TraverseFor(node.left, y))
                {
                    foundY = true;
                }
            }

            if (node.right != null)
            {
                if (!foundX && TraverseFor(node.right, x))
                {
                    foundX = true;
                }
                if (!foundY && TraverseFor(node.right, y))
                {
                    foundY = true;
                }
            }

            if (foundX && foundY && common == null)
            {
                common = node;
                return;
            }
        }

        private static bool TraverseFor(Node<T> node, T value)
        {
            if (node.data.CompareTo(value) == 0)
            {
                return true;
            }

            if (node.left != null && TraverseFor(node.left, value))
            {
                return true;
            }

            if (node.right != null && TraverseFor(node.right, value))
            {
                return true;
            }

            return false;
        }
    }
}
