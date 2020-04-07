using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class SweepStakesStackManager : ISweepStakesManager
    {
        //member variables
        Stack<SweepStakes> stack = new Stack<SweepStakes>();


        //constructor


        //member methods
        public void InsertSweepStakes(SweepStakes sweepstakes)
        {
            SweepStakes sweepStakes2 = sweepstakes;
            stack.Push(sweepstakes);
        }

        public SweepStakes GetSweepStakes()
        {
            return stack.Pop();
        }
    }
}
