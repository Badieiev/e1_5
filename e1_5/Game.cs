using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e1_5
{
    class Game
    {
        Team team1;
        Team team2;
        Judge judge;

        public Game(Team a, Team b, Judge j)
        {
            team1 = a;
            team2 = b;
            judge = j;
        }

        public void Сomparison2Teams(Team a, Team b)
        {
            if (judge.Preferences == 1)
            {
                Compare2TeamsByMastery(a,b, 1.1);
            }
            else if (judge.Preferences == 2)
            {
                Compare2TeamsByMastery(b,a, 1.1);
            }
            else
            {
                Compare2TeamsByMastery(a, b, 1);
            }
        }

        private void Compare2TeamsByMastery(Team a, Team b, double x)
        {
            if ((a.GetAllMastery() * x) - b.GetAllMastery() >= (a.GetAllMastery() * x) / 10)
            {
                Console.WriteLine("Team {0} win", a.Name);
            }
            else if (b.GetAllMastery() - (a.GetAllMastery() * x) >= b.GetAllMastery() / 10)
            {
                Console.WriteLine("Team {0} win", b.Name);
            }
            else
            {
                Console.WriteLine("Draw");
            }
        }
    }
}
