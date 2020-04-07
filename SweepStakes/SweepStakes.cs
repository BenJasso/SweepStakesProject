using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class SweepStakes
    {
        //member variables
        Dictionary<int, Contestant> contestants;
        

        

        string name;
       


        //constructor
        public SweepStakes(string name)
        {
            this.name = name;
            contestants = new Dictionary<int, Contestant>();
        }

        //member methods
        public void RegisterContestant(Contestant contestant)
        {
            contestant.firstName = UserInterface.GetUserInputFor("Please enter your first name: ");
            contestant.lastName = UserInterface.GetUserInputFor("Please enter your last name:  ");
            contestant.emailAddress = UserInterface.GetUserInputFor("Please enter your email address:  ");
            int registrationCounter = contestants.Count;


            contestant.registrationNumber = registrationCounter++;
            contestants.Add(contestant.registrationNumber, contestant);
            
            
        }

        public Contestant pickWinner()
        {
            Random random = new Random();
            int randomRegistrationNumber = random.Next(0, contestants.Count);
            return contestants[randomRegistrationNumber];

            

        }

        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine($"Winner Info\nName:{contestant.firstName} {contestant.lastName}\nEmail Address:{contestant.emailAddress}");
        }
    }
}