using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class Program  
    {
        static void Main(string[] args)
        {

            ISweepStakesManager sweepStakesManager = UserInterface.GetChoiceOfManager();
            MarketingFirm marketingFirm = new MarketingFirm(sweepStakesManager);
            marketingFirm.CreateSweepStake();



            
            SweepStakes current = marketingFirm.manager.GetSweepStakes();

            while (true)
            {
                Contestant contestant = new Contestant();
                string answer = UserInterface.GetUserInputFor("Type Enter to enter contestant info for the sweepstakes. Type end to end entry submissions.");
                

                if (answer == "enter")
                {
                   current.RegisterContestant(contestant);
                    Console.Clear();
                }
                else if (answer == "end")
                {
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.WriteLine("invalid entry, try again");
                }



            }
            Console.WriteLine("Press enter to pick winner");
            Contestant winner = current.pickWinner();
            current.PrintContestantInfo(winner);
            Console.ReadLine();
            
            
        }
    }
}
