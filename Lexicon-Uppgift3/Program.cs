using Lexicon_Uppgift3.Helpers;
using Lexicon_Uppgift3.Menu;
using Lexicon_Uppgift3.SystemError;
using Lexicon_Uppgift3.Menus;

namespace Lexicon_Uppgift3;

internal class Program
{   
    //QUESTIONS

    //Vad händer om du försöker lägga till en Car i en lista av Motorcykel?
        //Då får man ett fel
    
    //Vilken typ bör en lista vara för att rymma alla fördonstyper?
        //Vehicle

    //Kommer du åt metoden Clean() från en lista med typen List<Vehicle>?
        //Nej

    //Vad är fördelarna med att använda interfaces istället av arv?
        //Att man kan, i en och samma kod bit, använda olika Klasser med samma gemensamma metoder.
    static void Main(string[] args)
    {
        //Del 1
        bool exit = false;
        do
        {
            try
            {
                AvailableMenus.mainMenu.ShowMenu();
                exit = AvailableMenus.mainMenu.ValidateAndExecuteOption(AvailableMenus.mainMenu.PromptOptionChoice());
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                Console.Write(Environment.NewLine);
            }
            
        }
        while (!exit);


    }
}
