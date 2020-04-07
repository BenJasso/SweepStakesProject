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
        public ISweepStakesManager manager;

        //constructor
        public MarketingFirm(ISweepStakesManager manager) //dependency injection
        {
            this.manager = manager;
        }

        //member methods
        public void CreateSweepStake()
        {
           SweepStakes sweepStakes = new SweepStakes( UserInterface.GetUserInputFor("What would you like to call your Sweepstakes?"));
            manager.InsertSweepStakes(sweepStakes);

        }
        
    }
}
