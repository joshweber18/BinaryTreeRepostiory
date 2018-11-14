using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    class Program
    {
        static void Main(string[] args)
        {
            MarketingFirm marketingFirm = new MarketingFirm(FactoryDesign.GetDataStructure());
            marketingFirm.RunSweepstakes();

            //Contestant newContestant = new Contestant();
            //UI.GetFirstName(newContestant);
            //UI.GetLastName(newContestant);
            //UI.GetEmail(newContestant);
           

            
        }
    }
}
