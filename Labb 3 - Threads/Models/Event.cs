using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_3___Threads.Models
{
    public class Event
    {
        IList<Event> eventList = new List<Event>();

        public static void Events(Car car)
        {
            Thread.Sleep(10000);

            double carSpeed = car.Speed;
            double carStop = 0;

            int rnd = 0;

            rnd = Randomizer.rndNumber();
            if (rnd == 1)
            {
                Console.WriteLine("{0} ran out of gas. Refueling takes 30 sec.", car.Make);
                Console.WriteLine();
                car.Speed = carStop;
                Thread.Sleep(30000);
                car.Speed = carSpeed;
            }
            else if (rnd == 2 || rnd == 3)
            {
                Console.WriteLine("{0} has gotten a flat. Changing tires takes 20 sec.", car.Make);
                Console.WriteLine();
                car.Speed = carStop;
                Thread.Sleep(20000);
                car.Speed = carSpeed;
            }
            else if (rnd >= 4 && rnd <= 8)
            {
                Console.WriteLine("A bird flew into {0}s windshield. Cleaning it will take 10 sec.", car.Make);
                Console.WriteLine();
                car.Speed = carStop;
                Thread.Sleep(10000);
                car.Speed = carSpeed;
            }
            else if (rnd >= 9 && rnd <= 18)
            {
                Console.WriteLine("{0} has gotten an engine error. {0} will slow down by 1 km/h", car.Make);
                Console.WriteLine();
                car.Speed--;
            }
            Thread.Sleep(10000);
        }
    }
}
