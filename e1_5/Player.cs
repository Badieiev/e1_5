using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e1_5
{
    class Player
    {
        public string Name { get; set; }
        public int Age { get; set; }

        //создать класс Random с generic методом RandomNumber
        static Random random = new Random();
        int getRandomMastery;
        public int GetRandomMastery
        {
            get { return getRandomMastery; }
        }

        public static int GetRandomNumber(int min, int max)
        {
            return random.Next(min, max);
        }

        public Player(string name, int age)
        {
            Name = name;
            Age = age;
            this.getRandomMastery = GetRandomNumber(1, 100);
        }
    }
}
