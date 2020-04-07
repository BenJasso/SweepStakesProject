using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public static class UserInterface
    {

        //member variables


        //constructor


        //member methods
        public static  string GetUserInputFor(string prompt)
        {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        
        }

        public static ISweepStakesManager GetChoiceOfManager()
        {
            string choice = UserInterface.GetUserInputFor("What kind of manager would you like to hold all of your Sweepstakes?\nType 1 for a Stack.\nType 2 for a Queue.");
            while (true)
            {
                if (choice == "1")
                {
                    SweepStakesStackManager sweepStakesStackManager = new SweepStakesStackManager();
                    return sweepStakesStackManager;
                }
                else if (choice == "2")
                {
                    SweepStakesQueueManager sweepStakesQueueManager = new SweepStakesQueueManager();

                    return sweepStakesQueueManager;
                }
                else
                {
                    Console.WriteLine("Invalid option, select again.");
                }
            }
        }

        
    }
}
