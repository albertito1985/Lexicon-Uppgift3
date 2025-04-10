using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexicon_Uppgift3.Vehicles
{
    internal class Truck : Vehicle, ICleanable
    {
        public string CargoCapacity { get; set; } = "2500L";

        public Truck() { }
        public Truck(string inputBrand, string inputModel, int inputYear, double inputWeight) : base(inputBrand, inputModel, inputYear, inputWeight)
        {
            
        }

        public override string StartEngine()
        {
            return "BRUM BRUM BRUM BRUM!";
        }

        public override string Stats()
        {
            return $"Type: Truck\n" + 
                $"Brand: {Brand}\n" +
                $"Model: {Model}\n" +
                $"Year: {Year}\n" +
                $"Weight: {Weight} Kg\n" +
                $"CargoCapacity: {CargoCapacity}";
        }

        public string Clean()
        {
            return "This Truck is Cleanable";
        }
    }
}
