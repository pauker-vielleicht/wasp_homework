using Microsoft.VisualBasic;
using System;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Schema;

namespace example
{
    class Car
    {
        protected string model;
        protected int power;
        protected int date;

        public override string ToString()
        {
            string s = $"Model: {model} HorsePower: {power} Year: {date} ";
            return s;
        }

        public Car(string model, int power, int date)
        {
            this.model = model;
            this.power = power;
            this.date = date;
        }


    }

    class Passenger : Car
    {
        private int passengers;
        private Dictionary<string, int> repairbook = new Dictionary<string, int>();

        public Passenger(string model, int power, int year, int passengers) : base(model, power, year)
        {
            this.passengers = passengers;
        }

        public void AddRepair(string part, int year)
        {
            repairbook.Add(part, year);
        }

        public int GetYearOfRepair(string part)
        {
            int year = repairbook.ContainsKey(part) == true ? repairbook[part] : -1;
            return year;
        }
        public void Print()
        {
            foreach(var el in repairbook)
            {
                Console.WriteLine($"Part: {el.Key}  Year: {el.Value}.");
            }
        }
        public override string ToString()
        {
            string s = $"Passengers: {passengers}";
            return base.ToString() + s;
        }
    }

    class Truck : Car
    {
        private int capacity;
        private string drivername;
        private Dictionary<string, int> loadroaster = new Dictionary<string, int>();

        public Truck(string model, int power, int year, int capacity, string drivername) : base(model, power, year)
        {
            this.capacity = capacity;
            this.drivername = drivername;
        }
        public void ChangeDriver(string drivername)
        {
            this.drivername = drivername;
        }
        public void AddLoad(string name, int weight)
        {
            loadroaster.Add(name, weight);
        }
        public void DeleteLoad(string name)
        {
            loadroaster.Remove(name);
        }

        public void Print()
        {
            foreach (var el in loadroaster)
            {
                Console.WriteLine($"Part: {el.Key}  Year: {el.Value}.");
            }
        }
        public override string ToString()
        {
            string s = $"Capacity: {capacity} DriverName: {drivername} ";
            return base.ToString() + s;
        }
    }

    class Autopark
    {
        private string name;
        private List<Car> cars = new List<Car>();

        public Autopark(string name, List<Car> cars)
        {
            this.name = name;
            this.cars = cars;
        }

        public override string ToString()
        {
            string res = "";
            foreach( var el in cars)
            {
                res += el.ToString() +"\n";
            }
            return res;
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Car nn = new Car("noname", 20, 1999);
            Truck volvo = new Truck("Volvo", 800, 2012, 1500, "Petrovich");
            Passenger pas = new Passenger("dodge",418,2011,2);
            List<Car> cars = new List<Car>();
            cars.Add(pas);
            cars.Add(nn);
            cars.Add(volvo);
            Autopark test = new Autopark("test", cars);
            Console.Write(test);
        }
    }
}
