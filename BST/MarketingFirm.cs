using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    class MarketingFirm
    {
        // member variables (HAS A)
        ISweepstakesManager manager;
        //Sweepstakes sweepstake;
        //Contestant contestant;


        public MarketingFirm(ISweepstakesManager manager)
        {
            // contestant = new Contestant();
            this.manager = manager;
            Console.WriteLine("What would you like to name your Sweepstakes");
            string sweepstakesName = Console.ReadLine();
            // sweepstake = new Sweepstakes(sweepstakesName);
        }

        public void AddNewSweepstakes(Sweepstakes sweepstakes)
        {
            manager.InsertSweepstakes(sweepstakes);
        }

        public void GetNewSweepstakes(Sweepstakes sweepstakes)
        {
            manager.GetSweepstakes();
        }
    }
}
