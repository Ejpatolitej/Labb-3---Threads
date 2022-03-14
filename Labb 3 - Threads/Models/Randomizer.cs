using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_3___Threads.Models
{
    public class Randomizer
    {
        public static int rndNumber()
        {
            Random rnd = new Random();
            int rndNR = rnd.Next(0, 51);
            return rndNR;
        }   
    }
}
