namespace Lexicon_Uppgift3;

internal class Program
{
    static void Main(string[] args)
    {
        try
        {
            VehicleHandler.CreateVehicle("Mazda", "V70", 2025, 107.88);
            VehicleHandler.PrintVehicleList();
        }
        catch(ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
