using System;

namespace CarDemo
{
    class Car
    {
        private int year;
        private string manufacturer;
        private string model;
        private bool isDrivable;
        private double price;

        public Car(int y, string man, string m, bool drive, double p)
        {
            year = y;
            manufacturer = man;
            model = m;
            isDrivable = drive;
            price = p;
        }
        public override string ToString()
        {
            return string.Format("Year: {0}, Manfacturer: {1}, Model: {2}, IsDrivable?: {3}, Price: ${4}", year, manufacturer, model, isDrivable, price);
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            Car Ford = new Car(2016, "Ford", "GT", true, 1000000);
            Console.WriteLine(Ford);

            Car Toyota = new Car(2015, "Toyota", "Camry", true, 20000);
            Console.WriteLine(Toyota);

            Car Mazda = new Car(2017, "Mazda", "MX-5", true, 30000);
            Console.WriteLine(Mazda);

            Car BMW = new Car(2016, "BMW", "I8", true, 1000000);
            Console.WriteLine(BMW);
        }
    }
}

//class can be defined 
// - inside the method, inside of class, outside of class
// - can be use to create objects
// - user-defined types

//May have the following kind of members
//1) Fields
//2) Constructor
// - similiar to methods
// - no return type
// - name must match name of class
// - called immediately after object is created
// - used to put the object in a usable state
//3) Methods