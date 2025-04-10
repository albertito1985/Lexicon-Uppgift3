using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexicon_Uppgift3.Vehicles
{
    internal class ElectricScooter : Vehicle
    {
        public string BatteryRange { get; set; } = "4800Mhz";

        public ElectricScooter()
        {

        }
        public ElectricScooter(string inputBrand, string inputModel, int inputYear, double inputWeight) : base(inputBrand, inputModel, inputYear, inputWeight)
        {
        }

        public override string StartEngine()
        {
            return "Blip Blip!";
        }

        public override string Stats()
        {
            return $"Type: Electric Scooter\n" +
                $"Brand: {Brand}\n" +
                $"Model: {Model}\n" +
                $"Year: {Year}\n" +
                $"Weight: {Weight} Kg\n" +
                $"BatteryRange: {BatteryRange}";
        }
    }
}
