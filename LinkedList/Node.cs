using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparation.LinkedList
{
    public class Node<T> where T : IComparable<T>
    {
        public Node<T> next;
        public T data;

        public Node(T data)
        {
            this.data = data;
        }

        public bool IsLessThan(Node<T> otherNode)
        {
            return this.IsLessThan(otherNode.data);
        }

        public bool IsLessThan(T value)
        {
            return (this.data.CompareTo(value) < 0);

        }

        public bool IsEqualTo(Node<T> otherNode)
        {
            return this.IsEqualTo(otherNode.data);
        }

        public bool IsEqualTo(T value)
        {
            return (this.data.CompareTo(value) == 0);
        }
    }
}
