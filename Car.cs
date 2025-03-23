using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClassLibrary
{
    //Model class
    public class Car
    {
        //Car properties
        public string make { get; set; }
        public string model { get; set; }
        public string color { get; set; }
        public int miles { get; set; }
        public int year { get; set; }
        public decimal price { get; set; }

        //default constructor
        public Car()
        {
            make = "Nothing Yet";
            model = "Nothing Yet";
            color = "Nothing Yet";
            year = 0;
            miles = 0;
            price = 0;

        }
        //Non default constructor
        public Car(string make, string model, string color, int miles, int year, decimal price)
        {
            this.make = make;
            this.model = model;
            this.color = color;
            this.miles = miles;
            this.year = year;
            this.price = price;
        }

        //override tostring to print out car specifics
        public override string ToString()
        {
            return color + " " + make + " " + model + " " + year + ", with " + miles + " miles for $" + price;
        }


    }
}
