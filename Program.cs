using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    class Program
    {
        static void Main(string[] args)
        {

            

            List<string> names = new List<string>();
            List<int> hunger = new List<int>();
            List<int> thirst = new List<int>();
            List<int> energy = new List<int>();

  
            Random generator = new Random();
            int hungerLevel;
            int thirstLevel;
            int energyLevel;
            int userInput;
            int employeeType;
            int numberOfPets = 3;
            int hoursWorked;
            int characteristic;
            bool petAdoption = false;
            bool check = false;
            string petNames;
            

            Manager owner = new Manager();
            Volunteer collegeKid = new Volunteer();
            AnimalCharacteristics typeNDiet = new AnimalCharacteristics();
            

            Console.WriteLine("Hello, before we get your title.  Lets take a look at the shelter pets!\n");
            Console.WriteLine("Looks like a full house! all 3 cages are full. Enter the pets names:");

            for (int i = 0; i < numberOfPets; i++)
            {
                petNames = Console.ReadLine().ToLower();
                names.Add(petNames);

                hungerLevel = generator.Next(0, 100);
                thirstLevel = generator.Next(0, 100);
                energyLevel = generator.Next(0, 100);

                hunger.Add(hungerLevel);
                thirst.Add(thirstLevel);
                energy.Add(energyLevel);
            }
            
                Pet petOne = new Pet(names[0], hunger[0], thirst[0], energy[0]);
                Pet petTwo = new Pet(names[1], hunger[1], thirst[1], energy[1]);
                Pet petThree = new Pet(names[2], hunger[2], thirst[2], energy[2]);

                Console.WriteLine("Thank you! What type of employee are you?");
                Console.WriteLine("1. Volunteer\n2. Manager");
                employeeType = int.Parse(Console.ReadLine());

                do
                {

                    Console.WriteLine("This is the status of your pets: ");
                    Console.WriteLine(String.Format("|{0,8}|{1,8}|{2,8}|{3,8}|", "Name", "Hunger", "Thirst", "Energy"));

                    petOne.PetStatus();
                    petTwo.PetStatus();
                    petThree.PetStatus();
  

                    if (employeeType == 1)
                    {

                        Console.WriteLine("\nWhat would you like to do next?");
                        Console.WriteLine("1. Feed ALL pets");
                        Console.WriteLine("2. Give ALL pets water");
                        Console.WriteLine("3. Play with one pet");
                        Console.WriteLine("4. Clock Out");

                        userInput = int.Parse(Console.ReadLine());

                        switch(userInput)
                        {
                            case 1:
                                  petOne.FeedAdjust();
                                  petTwo.FeedAdjust();
                                  petThree.FeedAdjust();
                                  collegeKid.Feed();
                                    
                                break;

                            case 2:

                                petOne.WaterAdjust();
                                petTwo.WaterAdjust();
                                petThree.WaterAdjust();
                                collegeKid.Water();

                                break;

                            case 3:
                                Console.WriteLine("Which pet would you like to play with? ");
                                for (int i = 0; i < numberOfPets; i++)
                                {
                                    Console.WriteLine((i + 1) + ". " + names[i]);
                                }
                                userInput = int.Parse(Console.ReadLine());

                                switch (userInput)
                                {
                                    case 1:
                                        petOne.PlayAdjust();
                                        break;
                                    case 2:
                                        petTwo.PlayAdjust();
                                        break;
                                    case 3:
                                        petThree.PlayAdjust();
                                        break;
                                }

                                break;

                             case 4:
                                Console.WriteLine("How many hours have you worked?");
                                hoursWorked = int.Parse(Console.ReadLine());
                                check = collegeKid.ClockOut(hoursWorked);

                                break;
                        }

                    }
                    else if (employeeType == 2)
                    {
                        Console.WriteLine("\nWhat would you like to do next?");
                        Console.WriteLine("1. Adopt a pet");
                        Console.WriteLine("2. Give one pet water");
                        Console.WriteLine("3. Feed one pet");
                        Console.WriteLine("4. Check inventory");
                        Console.WriteLine("5. Clock Out");


                        userInput = int.Parse(Console.ReadLine());

                    switch (userInput)
                    {
                        case 1:
                            Console.WriteLine("Which pet would you like to adopt? (Enter the number");

                            for (int i = 0; i < numberOfPets; i++)
                            {
                                Console.WriteLine((i + 1) + ". " + names[i]);
                            }
                            userInput = int.Parse(Console.ReadLine());

                            switch (userInput)
                            {
                                case 1:
                                    petAdoption = owner.Adopt();
                                    petOne.Name = "ADOPTED!";
                                    
                                    break;
                                case 2:
                                    petAdoption = owner.Adopt();
                                    petTwo.Name = "ADOPTED!";
                                    
                                    break;
                                case 3:
                                    petAdoption = owner.Adopt();
                                    petThree.Name = "ADOPTED!";
                                   
                                    break;
                            }
                            break;

                        case 2:

                            Console.WriteLine("Which pet would you like to give water? (Enter the number)");

                            for(int i = 0; i < numberOfPets; i++)
                            {
                                Console.WriteLine((i + 1) + ". " + names[i]);
                            }
                            userInput = int.Parse(Console.ReadLine());

                            switch (userInput)
                            {
                                case 1: 
                                petOne.WaterAdjust();
                                    break;
                                case 2:
                            petTwo.WaterAdjust();
                                    break;
                                case 3:
                            petThree.WaterAdjust();
                                    break;
                            }
                                break;

                            case 3:
                            Console.WriteLine("Which pet would you like to feed? (Enter the number)");
                            for (int i = 0; i < numberOfPets; i++)
                            {
                                Console.WriteLine((i + 1) + ". " + names[i]);
                            }
                            userInput = int.Parse(Console.ReadLine());

                            switch (userInput)
                            {
                                case 1:
                                    petOne.FeedAdjust();
                                    break;
                                case 2:
                                    petTwo.FeedAdjust();
                                    break;
                                case 3:
                                    petThree.FeedAdjust();
                                    break;
                            }
                            break;

                            case 4:

                            for (int i = 0; i < numberOfPets; i++)
                            {
                                characteristic = generator.Next(1, 5);
                                Console.WriteLine(names[i] + " the " + typeNDiet.PetType(characteristic) + ". Eats a strict diet of " + typeNDiet.PetDiet(characteristic));
                            }

                            break;

                            case 5:

                            Console.WriteLine("How many hours have you worked?");
                            hoursWorked = int.Parse(Console.ReadLine());
                            check = owner.ClockOut(hoursWorked);
                                break;  
                        }
                    }
                    else
                        throw new ArgumentException("You did not enter a valid number");

                } while (check == false);


        




















        



            
        }
    }
}
