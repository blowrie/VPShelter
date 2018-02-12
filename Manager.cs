using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    class Manager : Employee 
    {

        //One property
        public int ManagerHours { get; set; }

        //One override Method 
        public override bool ClockOut(int ManagerHours)
        {
            if(ManagerHours < 8)
            {
                Console.WriteLine("You're a manager! you need to work 8 hours before you can clock out.\nYou are at " + ManagerHours + " hours.");
                return false;
            } else
                Console.WriteLine("You have put in a long days work go home and get some rest.");
                return true;
        }

        //Adoption Method 
        public override bool Adopt()
        {
            Console.WriteLine("Thank you for adopting a pet!");
            return true;
        }

    }
}
