using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_3___Threads.Models
{
    public class Background
    {
        public static void CollectInfo(Car volvo, Car koenigsegg, Car porsche)
        {
            while (true)
            {
                Console.ReadKey();
                Console.Clear();
                Car.GetInfo(volvo);
                Car.GetInfo(koenigsegg);
                Car.GetInfo(porsche);
            }
        }
    }
}
