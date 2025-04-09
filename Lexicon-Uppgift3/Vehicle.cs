using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexicon_Uppgift3
{
    public class Vehicle
    {
        private string brand;
        private string model;
        private int year;
        private double weight;

        public string Brand
        {
            get { return brand; }
            set
            {
                if(Validation2_20char(value))
                {
                    brand = value;
                }
                else
                {
                    throw new ArgumentException("Bad Input. Brand shoter than 2 or longer than 20 characters.");
                }
            }
        }
        public string Model 
        {
            get { return model; }
            set
            {
                if (Validation2_20char(value))
                {
                    model = value;
                }
                else
                {
                    throw new ArgumentException("Bad Input. Model shoter than 2 or longer than 20 characters.");
                }
            }
        }
        public int Year
        {
            get { return year; }
            set
            {
                if (value > 1886 && value <= DateTime.Now.Year) year = value;
                else throw new ArgumentException($"Bad Input. Accepted years from 1886-{DateTime.Now.Year}");
            }    
        }
        public double Weight
        {
            get { return weight; }
            set 
            { 
                    if (value > 0) weight = value;
                    else throw new ArgumentException($"Bad Input. Weight needs to be a possitive value.");                
            }
        }
        public Vehicle(string inputBrand, string inputModel, int inputYear, double inputWeight)
        {
            Brand = inputBrand;
            Model = inputModel;
            Year = inputYear;
            Weight = inputWeight;
        }

        private bool Validation2_20char(string input)
        {
            if (input.Length < 2 || input.Length > 20) {
                return false;
            }
            else
            {
                return true;
            }
            ;
        }

        public override string ToString()
        {
            return $"{brand} {model} {year} {weight} Kg";
        }
    }

    
}
