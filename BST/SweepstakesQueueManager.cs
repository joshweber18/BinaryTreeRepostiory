using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    class SweepstakesQueueManager : ISweepstakesManager
    {
        public Queue<Sweepstakes> sweepstakesQueue;

        public SweepstakesQueueManager()
        {
            sweepstakesQueue = new Queue<Sweepstakes>();
        }

        public void InsertSweepstakes(Sweepstakes sweepstake)
        {
            sweepstakesQueue.Enqueue(sweepstake);
        }

        Sweepstakes ISweepstakesManager.GetSweepstakes()
        {
            Sweepstakes newQueueSweepstake = sweepstakesQueue.Dequeue();
                return newQueueSweepstake;
        }

    }
}
