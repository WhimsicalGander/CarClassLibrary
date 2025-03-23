using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClassLibrary
{
    //Business class holding all logic and methods of program
    public class Store
    {
        //Properties for lists of cars
        public List<Car> carList { get; set; }
        public List<Car> shoppingList { get; set; }

        //constructor to set list properties
        public Store() 
        {
            carList = new List<Car>();
            shoppingList = new List<Car>();

        }

        //loops through list and returns combined price
        public decimal Checkout()
        {
            decimal total = 0;
            foreach (Car car in shoppingList)
            {
                total += car.price;
            }

            return total;
        }

        //Takes the object and deletes it from the list
        public void DeleteItem(Car car)
        {
            for (int i = 0; i < shoppingList.Count(); i++)
            {
                if ((shoppingList[i].make == car.make) && (shoppingList[i].model == car.model) && (shoppingList[i].color == car.color) && (shoppingList[i].miles == car.miles))
                {
                    shoppingList.RemoveAt(i);
                }



            }
        }

        //returns list of cars that match search key
        public List<Car> SearchItem(string key)
        {
            //temp list to hold matching cars
            List<Car> tempList = new List<Car>();

            for (int i = 0;i < carList.Count();i++)
            {
                string year = carList[i].year + "";
                if ((carList[i].make.Contains(key))|| (carList[i].model.Contains(key)) || (year == key))
                {
                    tempList.Add(carList[i]);
                }
            }

            return tempList;


        }
    }
}
