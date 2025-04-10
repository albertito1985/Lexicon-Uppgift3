using Lexicon_Uppgift3.Helpers;
using Lexicon_Uppgift3.Menu;
using Lexicon_Uppgift3.SystemError;
using Lexicon_Uppgift3.Menus;

namespace Lexicon_Uppgift3;

internal class Program
{
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
