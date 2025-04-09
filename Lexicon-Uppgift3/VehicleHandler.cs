using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexicon_Uppgift3
{
     public static class VehicleHandler
    {
        static private List<Vehicle> vehicleList= new List<Vehicle>();

        static public List<Vehicle> VehicleList { get { return vehicleList; } }

        static public void CreateVehicle(string inputBrand, string inputModel, int inputYear, double inputWeight)
        {
                VehicleList.Add(new Vehicle(inputBrand, inputModel, inputYear, inputWeight));
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
            foreach(Vehicle vehicle in vehicleList)
            {
                Console.WriteLine(vehicle.ToString());
            }
        }
    }
}
