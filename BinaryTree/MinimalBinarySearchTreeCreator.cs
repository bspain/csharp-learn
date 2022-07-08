using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparation.BinaryTree
{
    public class MinimalBinarySearchTreeCreator<T> where T : IComparable<T>
    {
        /* 4.3 - Given a sorted (increasing order) array with unique integer elements,
         * write an algorithm to create a binary search tree with minimal height.
         * ----
         * I overthought this one.  My initial thought was to split the array and
         * build left and right halfs.  Problem was, I got caught up thinking that 
         * using a priority queue approach with constant re-balancing was needed.
         * Once I realized that split and build from middle was the approach, it came
         * fairly quickly.
         * 
         * I did get caught up too much in calculating the start/end of each sub array
         * Remmber, int div is nothing to overthink ( 5 / 2 == 2 ), no rounding involved.
         */

        public static Node<T> CreateFromSortedArray(T[] source)
        {
            return CreateFromSortedArray(source, 0, source.Length - 1);
        }

        public static Node<T> CreateFromSortedArray(T[] source, int start, int end)
        {
            Node<T> head;
            int len = (end - start) + 1;
            if(len == 3)  // 3 element array
            {
                head = new Node<T>(source[start + 1]);
                head.left = new Node<T>(source[start]);
                head.right = new Node<T>(source[end]);
                return head;
            }

            if (len == 2) // 2 element array 
            {
                head = new Node<T>(source[start + 1]);
                head.left = new Node<T>(source[start]);
                return head;
            }

            if (len == 1) // 1 element array
            {
                head = new Node<T>(source[start]);
                return head;
            }

            // Create a tree from the mid, left array, and right array

            int mid = start + (len / 2); // int div, 5 / 2 = 2, 4 / 2 = 2

            head = new Node<T>(source[mid]);
            head.left = CreateFromSortedArray(source, start, mid - 1);
            head.right = CreateFromSortedArray(source, mid + 1, end);

            return head;
        }
    }
}
