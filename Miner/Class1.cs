using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miner
{
    static class Class1
    {
       private static Random random = new Random();
        public static int RandomTo5()
        {
            return (random.Next(5));
        }
    }
}
