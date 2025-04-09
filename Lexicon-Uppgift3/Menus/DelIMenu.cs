using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lexicon_Uppgift3.Helpers;

namespace Lexicon_Uppgift3.Menu
{
    static public class DelIMenu
    {
        static public List<MenuOption> menuOptions = new List<MenuOption> {
            new MenuOption ("Exit", HandleExit),
            new MenuOption ("Enter Car", HandleEnterCar),
            new MenuOption ("Show Car List", HandleShowCarList),
        };

        static public bool HandleExit()
        {
            return true;
        }

        static public bool HandleEnterCar()
        {
            Console.WriteLine("\nEnter new car\n------------------");
            VehicleHandler.CreateVehicle();
            Console.Write(Environment.NewLine);
            return false;
        }

        static public bool HandleShowCarList()
        {
            Console.WriteLine("\nCars list\n------------------");
            VehicleHandler.PrintVehicleList();
            Console.Write(Environment.NewLine);
            Console.Write("Press any key to continue.");
            Console.ReadLine();
            
            return false;
        }
    }
}
