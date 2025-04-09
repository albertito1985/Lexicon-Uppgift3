using Lexicon_Uppgift3.Helpers;

namespace Lexicon_Uppgift3.Menu;

static public class MainMenu 
{
    static public List<MenuOption> menuOptions = new List<MenuOption>
    {
        new MenuOption("Exit", HandleExit),
        new MenuOption("Del I", HandleDelI),
        new MenuOption("Del II", HandleDelII),
    };

    static public bool HandleExit()
    {
        return true;
    }

    static public bool HandleDelI()
    {
        MenuHelper delIMenu = new MenuHelper("Del I",DelIMenu.menuOptions);
        bool exit = false;
        do
        {
            delIMenu.ShowMenu();
            exit = delIMenu.ValidateAndExecuteOption(delIMenu.PromptOptionChoice());
            
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
        Console.Write(Environment.NewLine);
        return false;
    }

}
