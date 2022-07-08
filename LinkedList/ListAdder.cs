using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparation.LinkedList
{
    public class ListAdder
    {
        /* 2.5 - Wyou have two numbers represented by a linked list, where each node
         * contains a single digit.  The digits are stored in reverse order, such that
         * the 1's digit is at the head of the list.  Write a function that adds the
         * two numbers and returns the sum as a linked list.
         * 
         * FOLLOW UP
         * 
         * Suppose the digits are stored in forward order.  Repeat the above problem.
         * 
         * 
         * --
         * Forward approach used iteration with carry going forward, and lots of null checks.
         * 
         * Reverse approach uses recursion.  The recurse approach proved easier to implement, 
         * via the use of padding (much less null checks).. the key to recursive impl is to 
         * think about getting to the basement first, and then working your way backwards.
         * */

        public static Node<int> AddListsForward(Node<int> l1, Node<int> l2)
        {
            Node<int> resultHead = null;
            Node<int> resultCur = null;

            var l1curr = l1;
            var l2curr = l2;

            int carry = 0;

            while (l1curr != null || l2curr != null || carry == 1)
            {
                int resultValue;

                resultValue = 
                    ((l1curr == null) ? 0 : l1curr.data) + 
                    ((l2curr == null) ? 0 : l2curr.data) + 
                    carry;

                if (resultValue >= 10)
                {
                    resultValue = resultValue - 10;
                    carry = 1;
                }
                else
                {
                    carry = 0;
                }

                if (l1curr != null)
                {
                    l1curr = l1curr.next;
                }
                if (l2curr != null)
                {
                    l2curr = l2curr.next;
                }

                var newNode = new Node<int>(resultValue);
                if (resultHead == null)
                {
                    resultHead = newNode;
                    resultCur = newNode;
                }
                else
                {
                    resultCur.next = newNode;
                    resultCur = newNode;
                }

            }

            return resultHead;
        }

        public static Node<int> AddListsRecurse(Node<int> a, Node<int> b)
        {
            // Need to pad first
            int aDepth = ListDepth(a);
            int bDepth = ListDepth(b);

            if (aDepth > bDepth)
            {
                b = Pad(b, (aDepth - bDepth));
            }
            if (bDepth > aDepth)
            {
                a = Pad(a, (bDepth - aDepth));
            }

            var head = AddNodesRecurse(a, b);

            if (head.data < 10)
            {
                return head;
            }

            head.data = head.data - 10;
            var newHead = new Node<int>(1);
            newHead.next = head;
            return newHead;
        }

        private static int ListDepth(Node<int> x)
        {
            if (x.next == null)
            {
                return 1;
            }
            else
            {
                return ListDepth(x.next) + 1;
            }
        }

        private static Node<int> Pad(Node<int> x, int padding)
        {
            Node<int> head = x;
            for(int p = 0; p < padding; p++)
            {
                Node<int> newNode = new Node<int>(0);
                newNode.next = head;
                head = newNode;
            }

            return head;
        }

        private static Node<int> AddNodesRecurse(Node<int> a, Node<int> b)
        {
            Node<int> thisNode;

            if (a.next == null && b.next == null)
            {
                thisNode = new Node<int>(a.data + b.data);
            }
            else
            {
                Node<int> resultNode = AddNodesRecurse(a.next, b.next);

                int carry = 0;
                if (resultNode.data >= 10)
                {
                    resultNode.data = resultNode.data - 10;
                    carry = 1;
                }

                thisNode = new Node<int>(a.data + b.data + carry);
                thisNode.next = resultNode;
            }

            return thisNode;
        }
    }
}
