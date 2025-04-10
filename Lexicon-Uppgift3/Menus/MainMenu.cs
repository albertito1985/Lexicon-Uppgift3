using Lexicon_Uppgift3.Helpers;
using Lexicon_Uppgift3.Menus;
using Lexicon_Uppgift3.Vehicles;

namespace Lexicon_Uppgift3.Menu;

static public class MainMenu
{
    static public List<MenuOption> menuOptions = new List<MenuOption>
    {
        new MenuOption("Exit", HandleExit),
        new MenuOption("Del I", HandleDelI),
        new MenuOption("Del II", HandleDelII),
        new MenuOption("Del IV", HandleDelIV)
    };

    static public bool HandleExit()
    {
        return true;
    }

    static public bool HandleDelI()
    {
        bool exit = false;
        do
        {
            AvailableMenus.delIMenu.ShowMenu();
            exit = AvailableMenus.delIMenu.ValidateAndExecuteOption(AvailableMenus.delIMenu.PromptOptionChoice());
            
        }while (!exit);
        return false;
    }

    static public bool HandleDelII()
    {
        Console.Write(Environment.NewLine);
        Console.WriteLine($"-----------------DEL II------------------");
        List<SystemError.SystemError> SystemErrors = [new SystemError.BrakeFailureError(), new SystemError.EngineFailureError(), new SystemError.TransmissionFailureError()];

        foreach (SystemError.SystemError Error in SystemErrors)
        {
            Error.ErrorMessage();
        }
        Utilities.PressAnyKeyToContinue();
        Console.Write(Environment.NewLine);
        return false;
    }

    static public bool HandleDelIV()
    {
        List<Vehicle> vehicleList = [
            new Car("Tesla", "XS", 2023, 2241.00),
            new ElectricScooter("Xiaomi", "electric scooter 3", 2023, 13.2),
            new Truck("Rivian", "R1T", 2023, 2400.00),
            new Motorcycle("Harley Davidson", "LiveWire", 2023, 249.00),
            new Car("BMW", "M3", 2023, 1.715),
        ];

        Console.WriteLine("\n--------------Vehicles List-----------");

        foreach (Vehicle vehicle in vehicleList)
        {
            Console.WriteLine($"{vehicle.Stats()} \nStart Engine: {vehicle.StartEngine()}" );
            if (vehicle is ICleanable)
            {
                ICleanable newVehicle = (ICleanable)vehicle;
                Console.WriteLine(newVehicle.Clean());
            }
            Console.Write(Environment.NewLine);
        }

        return false;
    }

}
