using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntermediateConcepts
{
    internal class Program
    {

        public class Car
        {
            //Fields 
            private string make;
            private string model;
            private int year;
            private double price;


            //Constructor 
            public Car(string make, string model, int year, double price)
            {
                this.make = make;
                this.model = model;
                this.year = year;
                this.price = price;
            }

           //Propeties 
           public string Make
            {
                get { return make; }
                set { make = value; }
            }

            public string Model
            {
                get { return model; }
                set { model = value; }
            }

            public int Year
            {
                get { return year; }
                set
                {
                    if (value > 1900 && value <= DateTime.Now.Year)
                        year = value;
                    else
                        throw new ArgumentOutOfRangeException("Year must be between 1900 and current year.");
                }
            }

            public double Price
            {
                get { return price; }
                set
                {
                    if (value >= 0)
                        price = value;
                    else
                        throw new ArgumentOutOfRangeException("Price must be a non-negative value.");
                }
            }


            public void Display()
            {
                Console.WriteLine($"Make: {make}, Model: {model}, Year: {year}, Price: ${price}");
            }

        }


        static void Main(string[] args)
        {
            //Creating an instance of Car class 

            Car car = new Car("Toyota", "Corolla", 2022, 25000);

            //Accessing Properties 
            car.Make = "Honda";
            car.Year = 2023;
            car.Price = 28000.0;

            //Displaying car Information
            car.Display();

            Console.ReadKey();
        }
    }
}
