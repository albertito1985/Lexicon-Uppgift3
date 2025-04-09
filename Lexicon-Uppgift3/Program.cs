using Lexicon_Uppgift3.Helpers;
using Lexicon_Uppgift3.Menu;
using Lexicon_Uppgift3.SystemError;

namespace Lexicon_Uppgift3;

internal class Program
{
    static void Main(string[] args)
    {
        //Del 1
        MenuHelper mainMenu = new MenuHelper("MAIN MENU",MainMenu.menuOptions);
        bool exit = false;
        do
        {
            try
            {
                mainMenu.ShowMenu();
                exit = mainMenu.ValidateAndExecuteOption(mainMenu.PromptOptionChoice());
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
