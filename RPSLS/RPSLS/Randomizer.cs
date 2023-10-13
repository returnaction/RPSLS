using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal static class Randomizer
    {
        public static int RandomNumber()
        {
            Random rnd = new Random();
            int number = rnd.Next(0, 5);
            return number;
        }
    }
}
