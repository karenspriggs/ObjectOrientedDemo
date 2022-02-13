using System;
using System.Collections.Generic;
using System.Text;

namespace SportsProject.Stats
{
    public class StatsFPS : PlayerStats
    {
        int headshots;

        public int Headshots { get => headshots; set => headshots = value; }
        public StatsFPS()
        {
            this.Wins = 0;
            this.Losses = 0;
            this.Rating = 0;
            this.Description = "Default fps description";
            this.headshots = 0;
        }
    }
}
