using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class MarketingFirm 
    {

        //member variables
        ISweepStakesManager manager;

        //constructor
        public MarketingFirm(ISweepStakesManager manager) //dependency injection
        {

        }

        //member methods
        public void CreateSweepStake()
        {
           SweepStakes sweepStakes = new SweepStakes( UserInterface.GetUserInputFor("What would you like to call your Sweepstakes?"));

        }
        
    }
}
