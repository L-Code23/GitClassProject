using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitClassProject
{//Define car Class
    public class Car
    {
        public string Make { get; }
        public string Model { get; }
        public int Year { get; }
        public decimal Price { get; }

        public Car(string make, string model, int year, decimal price)
        {
            Make = make;
            Model = model;
            Year = year;
            Price = price;

        }
        public override string ToString()
        {
            return $"{Make}\t{Model}\t{Year}\t{Price}";
        }
    }
}







