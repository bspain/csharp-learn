using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LL = InterviewPreparation.LinkedList;

namespace InterviewPreparation.BinaryTree
{
    public class LinkDepthNodes<T> where T : IComparable<T>
    {
        /* 4.4 Given a binary tree, design an algorithm which creates a linked list of all the
         * nodes at each depth (e.g., If you have a tree with depth D, you'll have D linked lists).
         * ----
         * Breadth First traversal came easy.  I struggled for a little bit thinking of a clever way to 
         * keep references to the tails, but a 2nd list proved to be a simple approach.  Being able to
         * tag each node with it's depth was key, otherwise some other data structure keeping track
         * of each node's depth would have been critical.  Not sure if there is an elegant way to keep
         * track of depth without going into recursion.
         * */

        public static List<LL.Node<T>> CreateDepthLists(Node<T> root)
        {
            List<LL.Node<T>> lists = new List<LL.Node<T>>();
            List<LL.Node<T>> tails = new List<LL.Node<T>>();

            Queue<Node<T>> queue = new Queue<Node<T>>();
            queue.Enqueue(root);

            // use tag on each node to note it's depth
            root.tag = 0;

            while (queue.Count > 0)
            {
                Node<T> node = queue.Dequeue();
                int depth = (int)node.tag;

                // Create/Add to Linked List
                if (lists.Count <= depth)
                {
                    lists.Add(new LL.Node<T>(node.data));
                    tails.Add(lists[depth]);
                }
                else
                {
                    tails[depth].next = new LL.Node<T>(node.data);
                    tails[depth] = tails[depth].next;
                }

                // Store depth on each child and enqueue
                if (node.left != null)
                {
                    node.left.tag = depth + 1;
                    queue.Enqueue(node.left);
                }

                if (node.right != null)
                {
                    node.right.tag = depth + 1;
                    queue.Enqueue(node.right);
                }
            }

            return lists;
        }
    }
}
