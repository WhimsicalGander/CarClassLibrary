using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClassLibrary
{
    public class FileIO
    {
        Store store;

        //constructor with store
        public FileIO(Store store)
        {
            this.store = store;
        }

        //saves current car list to text file
        public void SaveInventory()
        {
            string filename = "store.txt";

            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (Car car in store.carList)
                {
                    writer.WriteLine($"{car.make}, {car.model}, {car.color}, {car.miles}, {car.year}, {car.price}");
                }

            }
        }

        //loads list of cars from file to list
        public List<Car> LoadStore()
        {
            List<Car> cars = new List<Car>();
            string filename = "store.txt";

            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    string make = parts[0];
                    string model = parts[1];
                    string color = parts[2];
                    try
                    {
                        int miles = int.Parse(parts[3]);
                        int year = int.Parse(parts[4]);
                        decimal price = decimal.Parse(parts[5]);
                        Car car = new Car(make, model, color, miles, year, price);
                        cars.Add(car);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error parsing data for car on line " + line);
                    }
                }
            }
            return cars;

        }
    }
}
