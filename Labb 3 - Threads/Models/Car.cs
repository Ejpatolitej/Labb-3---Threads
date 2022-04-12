using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_3___Threads.Models
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Speed { get; set; } = 0;
        public double Distance { get; set; } = 0;

        public static IList<Car> CarList { get; set;} = new List<Car>();

        public Car(string make, string model, int year)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }

        public static void StartRace(Car car)
        {
            Thread eventThread = new Thread(() => Event.Events(car));
            eventThread.Start();

            car.Speed = 120;
            while (car.Distance < 5)
            {
                car.Distance += car.Speed / 3600;
                Thread.Sleep(1000);
            }
            CarList.Add(car);
        }

        public static void GetInfo(Car car)
        {
            Console.WriteLine("Car: {0} \n\tModel: {1} \n\tYear: {2} \n\tDistance: {3:f2} / 10 km \n\tSpeed: {4}", car.Make, car.Model, car.Year, car.Distance, car.Speed);
            Console.WriteLine();
        }
    }
}
