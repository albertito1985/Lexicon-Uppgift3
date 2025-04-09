using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lexicon_Uppgift3.Helpers;
using Lexicon_Uppgift3.Vehicles;

namespace Lexicon_Uppgift3
{
    static public class DelIMenu
    {
        static public List<MenuOption> MenuOptions = new List<MenuOption>{
            new MenuOption("Exit", HandleExit),
            new MenuOption("Car", CreateCar),
            new MenuOption("Electric Scooter", CreateScooter),
            new MenuOption("Motorcycle", CreateMotorcycle),
            new MenuOption("Truck", CreateTruck)
            }

        static public bool HandleExit()
        {
            return true;
        }

        static public bool CreateCar()
        {
            Console.WriteLine("\nEnter new car\n------------------");
            VehicleHandler.CreateVehicle();
            Console.Write(Environment.NewLine);
            return false;
        }

    }
}
