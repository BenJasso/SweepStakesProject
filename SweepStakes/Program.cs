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
            
            SweepStakes sweep = new SweepStakes("wincar");

            while (true)
            {
                Contestant contestant = new Contestant();
                string answer = UserInterface.GetUserInputFor("Would you like to enter for the sweepstakes?");
                

                if (answer == "yes")
                {
                    sweep.RegisterContestant(contestant);
                    Console.Clear();
                }
                else
                {
                    break;
                }



            }

            Contestant winner = sweep.pickWinner();
            sweep.PrintContestantInfo(winner);
            Console.ReadLine();
            
            
        }
    }
}
