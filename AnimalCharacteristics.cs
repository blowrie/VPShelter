using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    class AnimalCharacteristics
    {
        
        public string Type { get; set; }
        public string Diet { get; set; }

        //Type Property
        public string PetType(int decider) 
        {
            if (decider == 1)
            {
                return "the Silly Squirrel";
            }
            else if (decider == 2)
            {
                return "the Dopey Doggy";
            }
            else if (decider == 3)
            {
                return "the Hungry Catepillar";
            }
            else if (decider == 4)
            {
                return "the Crazy Cat";
            }
            else 
                return "the Giant Gerbel";
            
                    
        }       // Just practiced two different ways.  If statement and switch.  

        //Diet Property
        public string PetDiet(int decider)
        {
            switch(decider)
            {
                case 1:
                    return "blueberries.";

                case 2:
                    return "shrimp fried rice.";

                case 3:
                    return "chicken noodle soup.";

                case 4:
                    return "tacos & burritos.";

                case 5:
                    return "burgers and milkshakes.";

                default:
                    return "fish and chips";
            }
        }
    }
}
