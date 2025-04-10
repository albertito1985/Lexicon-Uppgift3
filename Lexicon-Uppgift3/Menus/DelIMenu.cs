using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lexicon_Uppgift3.Helpers;
using Lexicon_Uppgift3.Menus;

namespace Lexicon_Uppgift3.Menu
{
    public static class DelIMenu
    {
        public static List<MenuOption> menuOptions = new List<MenuOption> {
            new MenuOption ("Exit", HandleExit),
            new MenuOption ("Enter Vehicle", HandleEnterVehicle),
            new MenuOption ("Show Vehicle List", HandleShowVehicleList),
        };

        public static bool HandleExit()
        {
            return true;
        }

        public static bool HandleEnterVehicle()
        {
            Console.WriteLine("\nEnter new vehicle\n------------------");
            VehicleHandler.CreateVehicle();
            Console.Write(Environment.NewLine);
            return false;
        }

        public static bool HandleShowVehicleList()
        {
            Console.WriteLine("\nVehicle list\n------------------");
            VehicleHandler.PrintVehicleList();
            Console.Write(Environment.NewLine);
            Utilities.PressAnyKeyToContinue();
            return false;
        }
    }
}
