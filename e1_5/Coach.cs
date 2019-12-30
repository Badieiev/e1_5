using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e1_5
{
    class Coach
    {
        public string NameCoach { get; set; }

        static Random random = new Random();
        double getRandomLucky;
        public double GetRandomLucky
        {
            get { return getRandomLucky; }
            set { getRandomLucky = value; }
        }

        public static double GetRandomNumber(double min, double max)
        {
            return random.NextDouble() * (max - min) + min;
        }

        public Coach(string name)
        {
            NameCoach = name;
            this.getRandomLucky = GetRandomNumber(0.5, 1.5);
        }
    }
}
