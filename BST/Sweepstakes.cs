using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    public class Sweepstakes
    {
        Dictionary<int, Contestant> Contestants = new Dictionary<int, Contestant>();
        int RegistrationNumberAssigned = 1;

        public void Sweepstakes()
        {

        }

        public void RegisterContestant(Contestant contestant)
        {
            Contestants.Add(contestant.RegistrationNumber, contestant);
            RegistrationNumberAssigned = contestant.RegistrationNumber;
            RegistrationNumberAssigned++;
            int key = contestant.RegistrationNumber;
        }

        public string PickWinner()
        {
            string WinnerChoosen;
            Random Winner = new Random();
            int randomContestant = Winner.Next(1, Contestants.Count);
            WinnerChoosen = Contestants[randomContestant].FirstName + " " + Contestants[randomContestant].LastName;
            return WinnerChoosen;
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            UI.DisplayFirstName(contestant);
            UI.DisplayLastName(contestant);
            UI.DisplayEmail(contestant);
        }
    }
}
