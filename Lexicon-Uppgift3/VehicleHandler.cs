using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lexicon_Uppgift3.Helpers;
using Lexicon_Uppgift3.Vehicles;

namespace Lexicon_Uppgift3
{
     public static class VehicleHandler
    {
        static private List<Vehicle> vehicleList= new List<Vehicle>();

        static public List<Vehicle> VehicleList { get { return vehicleList; } }

        static public void CreateVehicle()
        {
            bool validated = false;
            Vehicle newVehicle;
            do
            {
                Console.Write("Which type of vehicle do you want to introduce?\n" +
                "1. Car\n" +
                "2. Electric Scooter\n" +
                "3. Motorcycle\n" +
                "4. Truck\n" +
                "Choose an alternative: ");
                int choice = Utilities.NumberInput();

                switch (choice)
                {
                    case 1:
                        newVehicle = new Car();
                        validated = true;
                        break;
                    case 2:
                        newVehicle = new ElectricScooter();
                        validated = true;
                        break;
                    case 3:
                        newVehicle = new Motorcycle();
                        validated = true;
                        break;
                    case 4:
                        newVehicle = new Truck();
                        validated = true;
                        break;
                    default:
                        throw new ArgumentException("Enter a valid number.");
                        break;
                }

            } while (!validated);
            

            Console.Write("Enter the brand of your vehicle: ");
            newVehicle.Brand = Utilities.StringInput();

            Console.Write("Enter the model of your vehicle: ");
            newVehicle.Model = Utilities.StringInput();

            Console.Write("Enter the year of your vehicle: ");
            newVehicle.Year = Utilities.NumberInput();

            Console.Write("Enter the weight of your vehicle: ");
            newVehicle.Weight = Utilities.DoubleInput();

            VehicleList.Add(newVehicle);
        }

        static public void ChangeBrand(Vehicle inputVehicle, string newBrand)
        {
            inputVehicle.Model = newBrand;
        }

        static public void ChangeModell(Vehicle inputVehicle, string newModel)
        {
            inputVehicle.Model = newModel;
        }

        static public void ChangeYear(Vehicle inputVehicle, int newYear)
        {
            inputVehicle.Year = newYear;
        }

        static public void ChangeWeight(Vehicle inputVehicle, int newWeight)
        {
            inputVehicle.Weight = newWeight;
        }

        static public void PrintVehicleList()
        {   
            if(vehicleList.Count < 1)
            {
                Console.WriteLine("No vehicles introduced yet.");
            }
            else
            {
                foreach (Vehicle vehicle in vehicleList)
                {
                    Console.WriteLine(vehicle.ToString());
                }
            }
                
        }
    }
}
