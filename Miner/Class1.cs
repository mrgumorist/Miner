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
        public static List<string> results = new List<string>();
        public static int RandomTo5()
        {
            return (random.Next(5));
        }
        public static int RandomTo10()
        {
            return (random.Next(10));
        }
        public static int RandomTo20()
        {
            return (random.Next(20));
        }
        public static void AddToTop(string name, int score)
        {
            string end = $"Name: {name}, score: {score}";
            results.Add(end);
        }
    }
}
