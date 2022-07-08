using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparation.StacksAndQueues
{
    /* 3.4 - Towers of Hanoi implementation
     * ---
     * Think closely about the logic at each step.  The recursion became simpler when
     * I thought of each piece as wanting to move, but seeing it couldn't, and then telling
     * the one in front of it to move to the other side.  Be sure to check, when the recurse
     * comes back, to not assume it can move, but to check again, and if not, order the
     * next piece over to move again.
     * */

    public class MoveRecord
    {
        public int Value { private set; get; }
        public int SrcStack { private set; get; }
        public int DestStack { private set; get; }

        public MoveRecord(int value, int srcStack, int destStack)
        {
            this.Value = value;
            this.SrcStack = srcStack;
            this.DestStack = destStack;
        }

        public bool IsEqualTo(int Value, int SrcStack, int DestStack)
        {
            return (this.Value == Value &&
                this.SrcStack == SrcStack &&
                this.DestStack == DestStack);
        }
    }

    public class HanoiTower
    {
        public Queue<MoveRecord> MoveRecord { private set; get; }

        Stack<int>[] stacks;
        int depth;

        public HanoiTower(int depth)
        {
            this.stacks = new Stack<int>[3];
            this.stacks[0] = new Stack<int>();
            this.stacks[1] = new Stack<int>();
            this.stacks[2] = new Stack<int>();
            this.depth = depth;

            for (int x = depth; x > 0; x--)
            {
                this.stacks[0].Push(x);
            }

            this.MoveRecord = new Queue<MoveRecord>();
        }

        public void Go()
        {
            while (this.stacks[2].Count < this.depth)
            {
                this.AnalyzeAndMoveForward(0);
            }
        }

        public Stack<int> GetResults()
        {
            return this.stacks[2];
        }

        private void AnalyzeAndMoveForward(int srcStack)
        {
            if(srcStack == 2)
            {
                return;
            }

            int v = this.stacks[srcStack].Peek();

            if (this.stacks[srcStack + 1].Count == 0 ||
                this.stacks[srcStack + 1].Peek() > v)
            {
                this.Move(srcStack, srcStack + 1);
                this.AnalyzeAndMoveForward(srcStack + 1);
            }
            else
            {
                this.AnalyzeAndMoveBackward(srcStack + 1);

                // Make sure to not assume it can move, but to analyze and move accordingly.
                this.AnalyzeAndMoveForward(srcStack);
            }
        }

        private void AnalyzeAndMoveBackward(int srcStack)
        {
            if (srcStack == 0)
            {
                return;
            }

            int v = this.stacks[srcStack].Peek();
            if (this.stacks[srcStack - 1].Count == 0 ||
                this.stacks[srcStack - 1].Peek() > v)
            {
                this.Move(srcStack, srcStack - 1);
                this.AnalyzeAndMoveBackward(srcStack - 1);
            }
            else
            {
                this.AnalyzeAndMoveForward(srcStack - 1);
                this.AnalyzeAndMoveBackward(srcStack);
            }
        }

        private void Move(int srcStack, int destStack)
        {
            int v = this.stacks[srcStack].Pop();
            this.stacks[destStack].Push(v);

            this.MoveRecord.Enqueue(new MoveRecord(v, srcStack, destStack));
        }
    }
}
