using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    class FactoryDesign
    {
        static public ISweepstakesManager GetDataStructure()
        {
            Console.WriteLine("Would you like to store your Sweepstakes data in a stack or a queue?");
            string switchthing = Console.ReadLine();
            switch (switchthing)
            {
                case "stack":
                return new SweepstakesStackManager();
                case "queue":
                return new SweepstakesQueueManager();
                default:
                    GetDataStructure();
                    throw new AccessViolationException("Not a valid data structure.");
                    
            }
        }
    }  
}
