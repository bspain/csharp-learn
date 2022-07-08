using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparation.BinaryTree
{
    /* 4x - Not specific to any question, but a quick implementation of tree searching
     * algorithms */

    public enum TraverseType
    {
        InOrder,
        PreOrder,
        PostOrder,
        BreadthFirst
    }

    public class TreeTraverser<T> where T : IComparable<T>
    {
        private Node<T> root;

        public TreeTraverser(Node<T> root)
        {
            this.root = root;
        }

        public string Traverse()
        {
            return this.Traverse(TraverseType.InOrder);
        }

        public string Traverse(TraverseType t)
        {
            List<T> results = new List<T>();
            
            switch(t)
            {
                case TraverseType.InOrder:
                    this.InOrderTraverse(this.root, results);
                    break;
                case TraverseType.PreOrder:
                    this.PreOrderTraverse(this.root, results);
                    break;
                case TraverseType.PostOrder:
                    this.PostOrderTraverse(this.root, results);
                    break;
                case TraverseType.BreadthFirst:
                    this.BreadthFirstTraverse(this.root, results);
                    break;
            }
            return this.FormatResults(results);
        }

        private void InOrderTraverse(Node<T> current, List<T> results)
        {
            // Go left
            if (current.left != null)
            {
                this.InOrderTraverse(current.left, results);
            }

            // Visit
            results.Add(current.data);

            // Go right
            if (current.right != null)
            {
                this.InOrderTraverse(current.right, results);
            }
        }

        private void PreOrderTraverse(Node<T> current, List<T> results)
        {
            // Visit
            results.Add(current.data);

            // Go left
            if (current.left != null)
            {
                this.PreOrderTraverse(current.left, results);
            }

            // Go right
            if (current.right != null)
            {
                this.PreOrderTraverse(current.right, results);
            }
        }

        private void PostOrderTraverse(Node<T> current, List<T> results)
        {
            // Go left
            if (current.left != null)
            {
                this.PostOrderTraverse(current.left, results);
            }

            // Go right
            if (current.right != null)
            {
                this.PostOrderTraverse(current.right, results);
            }

            // Visit
            results.Add(current.data);
        }

        private void BreadthFirstTraverse(Node<T> current, List<T> results)
        {
            Queue<Node<T>> queue = new Queue<Node<T>>();

            queue.Enqueue(current);
            while (queue.Count > 0)
            {
                // Dequeue and visit
                Node<T> node = queue.Dequeue();
                results.Add(node.data);

                // Enqueue all children
                if (node.left != null)
                {
                    queue.Enqueue(node.left);
                }
                if (node.right != null)
                {
                    queue.Enqueue(node.right);
                }
            }
        }

        private string FormatResults(List<T> results)
        {
            string resultString = "";
            foreach (T item in results)
            {
                resultString = resultString + item.ToString() + ",";
            }

            if (resultString.Length > 1)
            {
                resultString = resultString.TrimEnd(',');
            }

            return resultString;
        }
    }
}
