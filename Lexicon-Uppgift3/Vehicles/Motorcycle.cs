using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexicon_Uppgift3.Vehicles
{
    internal class Motorcycle : Vehicle
    {
        public string HasSideCar  { get; set; } = "YES";

        public Motorcycle()
        {

        }
        public Motorcycle(string inputBrand, string inputModel, int inputYear, double inputWeight) : base(inputBrand, inputModel, inputYear, inputWeight)
        {
        }
        public override string StartEngine()
        {
            return "Brum Brum Bruuuuuuuuuuuuuuuuuum!";
        }

        public override string Stats()
        {
            return $"Type: Motorcycle\n" + 
                $"Brand: {Brand}\n" +
                $"Model: {Model}\n" +
                $"Year: {Year}\n" +
                $"Weight: {Weight} Kg\n" +
                $"HasSideCar: {HasSideCar}";
        }
    }
}
