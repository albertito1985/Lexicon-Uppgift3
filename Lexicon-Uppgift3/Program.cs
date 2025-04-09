using Lexicon_Uppgift3.SystemError;

namespace Lexicon_Uppgift3;

internal class Program
{
    static void Main(string[] args)
    {
        //Del 1
        try
        {
            Console.WriteLine("DEL1\n");
            //Det står inte att man ska göra en Console.Readline så jag gjorde inmatningen Hård kodade
            VehicleHandler.CreateVehicle("Mazda", "V70", 2025, 107.88); //Rätt input
            VehicleHandler.CreateVehicle("Z", "GOKU", 2020, 100.48); //felaktigt input (märket har mindre än 2 karaktärer)
            VehicleHandler.PrintVehicleList();
        }
        catch(ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }

        //Del2
        Console.WriteLine("\nDEL2\n");
        List<SystemError.SystemError> SystemErrors = [new SystemError.BrakeFailureError(), new SystemError.EngineFailureError(), new TransmissionFailureError()];

        foreach(SystemError.SystemError Error in SystemErrors)
        {
            Error.ErrorMessage();
        }


    }
}
