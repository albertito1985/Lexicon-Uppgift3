using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexicon_Uppgift3.Helpers
{
    public class MenuOption
    {
        //private int inputCount = 0;
        public delegate bool HandlerFunction();

        public static int InputCount { get; set; } = 0;
        public int Command { get; set; }
        public string Description { get; set; }
        public HandlerFunction Handler { get; set; }

        public MenuOption(string inputDescription, HandlerFunction inputFunction)
        {
            Command = InputCount;
            Description = inputDescription;
            Handler = inputFunction;
            InputCount++;
        }
        public void ResetInputCount()
        {

        }
    }
}
