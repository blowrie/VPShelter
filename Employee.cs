using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    class Employee
    {
        //property (req 1)
        public int Hours { get; set; }
        public bool Adoption { get; set; }

        //2 abstract methods
        public virtual bool ClockOut(int hours)
        {
            return false;
        }

        public virtual bool Adopt()
        {
            return true;
        }

        
    }
}
