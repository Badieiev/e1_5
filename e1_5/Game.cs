using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e1_5
{
    class Game
    {
        Team Dnipro;
        Team Zoria;

        public Game(Team a, Team b)
        {
            Dnipro = a;
            Zoria = b;
        }

        public void Сomparison2Teams(Team a, Team b)
        {
            if (a.SumMastery / b.SumMastery >= a.SumMastery / 10)
            {
                Console.WriteLine("Team {0} win", a.NameTeam);
            }
            if (b.SumMastery / a.SumMastery >= b.SumMastery / 10)
            {
                Console.WriteLine("Team {0} win", b.NameTeam);
            }
            else
            {
                Console.WriteLine("Drove");
            }
        }
    }
}
