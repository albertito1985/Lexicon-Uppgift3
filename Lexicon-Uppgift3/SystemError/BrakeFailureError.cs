using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexicon_Uppgift3.SystemError
{
    public class BrakeFailureError : SystemError
    {
        public override void ErrorMessage()
        {
            Console.WriteLine("Brake error. Decrease the speed of the car until it stops. Then apply the parking break.");
        }
    }
}
