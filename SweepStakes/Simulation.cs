using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class Simulation
    {
        //member variables


        //constructor


        //member methods
        public void CreateMarketingFirmWithManager()
        {
            ISweepStakesManager sweepStakesManager = UserInterface.GetChoiceOfManager();
            MarketingFirm marketingFirm = new MarketingFirm(sweepStakesManager);
        }
    }
}
