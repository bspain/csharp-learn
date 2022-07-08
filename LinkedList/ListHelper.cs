using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparation.LinkedList
{
    public class ListHelper
    {
        public static Node<T> Build<T>(IEnumerable<T> values) where T : IComparable<T>
        {
            Node<T> head = null;
            Node<T> current = null;

            foreach (T value in values)
            {
                if (head == null)
                {
                    head = new Node<T>(value);
                    current = head;
                }
                else
                {
                    current.next = new Node<T>(value);
                    current = current.next;
                }
            }

            return head;
        }

        public static bool AreEqual<T>(Node<T> list1, Node<T> list2) where T : IComparable<T>
        {
            Node<T> current1 = list1;
            Node<T> current2 = list2;

            while (current1 != null)
            {
                if (!current1.IsEqualTo(current2))
                {
                    return false;
                }

                current1 = current1.next;
                current2 = current2.next;

                if (current1 == null && current2 != null)
                {
                    return false;
                }
                if (current2 == null && current1 != null)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
