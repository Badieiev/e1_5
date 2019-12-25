using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e1_5
{
    class Player
    {
        public string NamePlayer { get; set; }
        public int AgePlayer { get; set; }

        static Random random = new Random();
        int getRandomMastery;
        public int GetRandomMastery
        {
            get { return getRandomMastery; }
            set { getRandomMastery = value; }
        }

        public static int GetRandomNumber(int min, int max)
        {
            return random.Next(min, max);
        }

        public Player(string name, int age)
        {
            NamePlayer = name;
            AgePlayer = age;
            this.getRandomMastery = GetRandomNumber(1, 100);
        }
    }
}
