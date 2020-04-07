using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class SweepStakesQueueManager : ISweepStakesManager
    {

        //member variables
        Queue<SweepStakes> queue;


        //constructor


        //member methods
        public void InsertSweepStakes(SweepStakes sweepStakes)
        {
            queue.Enqueue(sweepStakes);

        }

        public SweepStakes GetSweepStakes()
        {
            return queue.Dequeue();
        }
    }
}
