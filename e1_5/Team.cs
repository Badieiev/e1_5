using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e1_5
{
    class Team
    {
        public string NameTeam { get; set; }
        List<Player> playees = new List<Player>();

        public void AddPlayee(Player p)
        {
            playees.Add(p);
        }

        int sumMastery;
        public int SumMastery
        {
            get { return sumMastery; }
            set { this.sumMastery = GetAllMastery(); }
        }
        public int GetAllMastery()
        {
            foreach (var playee in playees)
            {
                sumMastery += playee.GetRandomMastery;
            }
            return sumMastery;
        }
    }
}
