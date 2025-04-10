using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lexicon_Uppgift3.Helpers;
using Lexicon_Uppgift3.Menu;

namespace Lexicon_Uppgift3.Menus
{
    public static class AvailableMenus
    {
        public static MenuHelper mainMenu = new MenuHelper("Main Menu",MainMenu.menuOptions);
        public static MenuHelper delIMenu = new MenuHelper("DelI Menu", DelIMenu.menuOptions);
    }
}
