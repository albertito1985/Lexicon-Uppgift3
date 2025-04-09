using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexicon_Uppgift3.SystemError
{
    public class TransmissionFailureError : SystemError
    {
        public override void ErrorMessage()
        {
            Console.WriteLine("Transmission error. Stop the car and call the mechanic.");
        }
    }
}
