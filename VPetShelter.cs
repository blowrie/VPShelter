using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    class VPetShelter : Pet
    {
        private string employeeName;
        private int employeeID;
        private string petName;
        private int petID;

        public string EmployeeName
        {
            get { return this.employeeName; }
            set { this.employeeName = value; }

        }
        public int EmployeeID
        {
           
            get { return this.employeeID; }
            set { this.employeeID = value; }
           
        }

        public string PetName
        {
            get { return this.petName; }
            set { this.petName = value; }
        }

        public int PetId
        {
            get { return this.petID; }
            set { this.petID = value; }

        }


        public VPetShelter(string employeeName, int employeeID, string petName, int petID )
        {
            this.employeeName = employeeName;
            this.employeeID = employeeID;
            this.petName = petName;
            this.petID = petID;
        }
        
    }
}
