using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexicon_Uppgift3.Vehicles
{
    internal class Car : Vehicle, ICleanable
    {
        public string TankCapacity { get; set; } = "100gal";
        public Car()
        {

        }
        public Car(string inputBrand, string inputModel, int inputYear, double inputWeight) : base(inputBrand, inputModel,inputYear,inputWeight)
        {
        }
        public override string StartEngine()
        {
            return "Brum Brum Brum!";
        }

        public override string Stats()
        {
            return $"Type: Car\n" +
                $"Brand: {Brand}\n" +
                $"Model: {Model}\n" +
                $"Year: {Year}\n" +
                $"Weight: {Weight} Kg\n" +
                $"TankCapacity: {TankCapacity}";
        }
        public string Clean()
        {
            return "This Car is Cleanable";
        }
    }
}
