using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparation.LinkedList
{
    public class ListPartitioner
    {
        /* 2.4 - Write code to partition a linked list around a value x, such that all nodes less than
         * x come before all nodes greater than or equal to x 
         * 
         * Approach: Build small then list, equal to list, and greater than list
         * Each node can be split off of the original list
         * Bring three lists together in order for result.
         * 
         * TECHINCALLY: The question allows for only two lists, less then, and greater then or equal
         * So I went a little overboard here - but I like it anyway :)
         * */

        public static Node<T> PartitionList<T>(Node<T> head, T partitionValue) where T : IComparable<T>
        {
            if (head == null)
            {
                return null;
            }

            if (head.next == null)
            {
                return head;
            }


            Node<T> ltHead = null;
            Node<T> ltTail = null;
            Node<T> ptHead = null;
            Node<T> ptTail = null;
            Node<T> gtHead = null;
            Node<T> gtTail = null;

            Node<T> current = head;

            while (current != null)
            {
                if (current.IsLessThan(partitionValue))
                {
                    if (ltHead == null)
                    {
                        ltHead = current;
                        ltTail = current;
                    }
                    else
                    {
                        ltTail.next = current;
                        ltTail = ltTail.next;
                    }
                }
                else if (current.IsEqualTo(partitionValue))
                {
                    if (ptHead == null)
                    {
                        ptHead = current;
                        ptTail = current;
                    }
                    else
                    {
                        ptTail.next = current;
                        ptTail = ptTail.next;
                    }
                }
                else
                {
                    if (gtHead == null)
                    {
                        gtHead = current;
                        gtTail = current;
                    }
                    else
                    {
                        gtTail.next = current;
                        gtTail = gtTail.next;
                    }
                }

                Node<T> temp = current;
                current = current.next;
                temp.next = null;
            }

            // Designate the new head
            Node<T> newHead;
            if (ltHead != null)
            {
                newHead = ltHead;

                if (ptHead != null)
                {
                    ltTail.next = ptHead;

                    if (gtHead != null)
                    {
                        ptTail.next = gtHead;
                    }
                }
                else if (gtHead != null)
                {
                    ltTail.next = gtHead;
                }
            }
            else if (ptHead != null)
            {
                newHead = ptHead;
                if (gtHead != null)
                {
                    ptTail.next = gtHead;
                }
            }
            else
            {
                newHead = gtHead;
            }

            return newHead;
        }
    }
}
