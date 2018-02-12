using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    class Volunteer : Employee
    {
        //One property
        public int VolHours { get; set; }

        //One override method 
        public override bool ClockOut(int VolHours)
        {
            if(VolHours < 4)
            {
                Console.WriteLine("Sorry a volunteer needs to work for at least 4 hours.\nYou are at " + VolHours + " hours.");
                return false;
            }
            else
                Console.WriteLine("Thank you for volunteering and putting in the time! Please come back soon.");
            return true;
        }

        //Feed Method
        public void Feed()
        {
            Console.WriteLine("You fed the pets! Great work!\n");
        }

        //Water Method
        public void Water()
        {
            Console.WriteLine("You gave the pets water! Great work!\n" );
        }

    }
}
