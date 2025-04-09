using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexicon_Uppgift3.Helpers
{
    public class MenuHelper
    {
        private List<MenuOption> MenuOptionsList { get; set; }
        private string menuName;

        public MenuHelper(string inputName,List<MenuOption> optionsList)
        {
            menuName = inputName;
            MenuOptionsList = optionsList;
            MenuOption.InputCount = 0;
        }
        public void ShowMenu()
        {
            Console.WriteLine($"-----------------{menuName}------------------");
            foreach (MenuOption option in MenuOptionsList)
            {
                Console.WriteLine($"{option.Command}: {option.Description}");

            }
            Console.WriteLine("---------------------------------------");
        }

        public int PromptOptionChoice()
        {
            Console.WriteLine("Type the number of the option you want to follow.");
            Console.Write("Option: ");
            return Utilities.NumberInput();
        }

        public bool ValidateAndExecuteOption(int choice)
        {
            bool exit = false;

            foreach (MenuOption option in MenuOptionsList)
            {
                if (option.Command == choice)
                {
                    exit = option.Handler();
                    break;
                }
            }

            return exit;
        }
    }
}
