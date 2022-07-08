using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparation.StacksAndQueues
{
    /* 3.5 - Implement a Queue class which only uses two stacks.
     * 
     * On enqueue, everything from stack prim must get pop'd, then the new
     * item is pushed, and then everything pop'd back onto prim
     * */

    public class QueueUsingStacks<T>
    {
        private Stack<T> prim;
        private Stack<T> seco;

        public QueueUsingStacks()
        {
            this.prim = new Stack<T>();
            this.seco = new Stack<T>();
        }

        public void Enqueue(T item)
        {
            // Pop everything from prim to seco
            this.popToSeco();

            // Push new item
            this.seco.Push(item);

            // Pop everything back to prim
            this.popToPrim();
        }

        public T Dequeue()
        {
            return this.prim.Pop();
        }
    

        private void popToSeco()
        {
            while(this.prim.Count > 0)
            {
                var item = this.prim.Pop();
                this.seco.Push(item);
            }
        }

        private void popToPrim()
        {
            while(this.seco.Count > 0)
            {
                var item = this.seco.Pop();
                this.prim.Push(item);
            }
        }

    }
}
