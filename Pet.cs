using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    class Pet
    {
        static Random generator = new Random();
        int decrease = generator.Next(15, 30);

        //fields
        private string name;
        private int hungerLevel;
        private int thirstLevel;
        private int energyLevel;

        //properties
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int HungerLevel
        {
            get { return this.hungerLevel; }
            set { this.hungerLevel = value; }
        }

        public int ThirstLevel
        {
            get { return this.thirstLevel; }
            set { this.thirstLevel = value; }
        }

        public int EnergyLevel
        {
            get { return this.energyLevel; }
            set { this.energyLevel = value; }
        }

        //2 Constructors
        public Pet()
        {

        }

        public Pet(string name, int hungerLevel, int thirstLevel, int energyLevel)
        {
            this.name = name;
            this.hungerLevel = hungerLevel;
            this.thirstLevel = thirstLevel;
            this.energyLevel = energyLevel;

        }

        //Methods 

       public void PetStatus()
        {
           Console.WriteLine(String.Format("|{0,8}|{1,8}|{2,8}|{3,8}|", Name, HungerLevel, ThirstLevel, EnergyLevel));   
        }
       

        public void FeedAdjust()
        {
            hungerLevel = 100;
            thirstLevel -= decrease;
            if(thirstLevel < 0)
            {
                thirstLevel = 0;
            }
            
        }
      
        public void WaterAdjust()
        {
            thirstLevel = 100;
        }

        public virtual void PlayAdjust()
        {
            energyLevel = 100;
            hungerLevel -= decrease;
            if(hungerLevel < 0)
            {
                hungerLevel = 0;
            }
        }
    }
}