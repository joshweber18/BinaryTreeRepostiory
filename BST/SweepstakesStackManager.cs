using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    class SweepstakesStackManager : ISweepstakesManager
    {
        public Stack<Sweepstakes> sweepstakesStack;

        public SweepstakesStackManager()
        {
            sweepstakesStack = new Stack<Sweepstakes>();
        }

        public void InsertSweepstakes(Sweepstakes sweepstake)
        {
            sweepstakesStack.Push(sweepstake);
        }

        Sweepstakes ISweepstakesManager.GetSweepstakes()
        {
            Sweepstakes newStackSweepStakes = sweepstakesStack.Pop();
            return newStackSweepStakes;
        }

    }
}
