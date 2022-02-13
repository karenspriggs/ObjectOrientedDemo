using System;
using System.Collections.Generic;
using System.Text;

namespace SportsProject.Stats
{
    public class StatsMOBA : PlayerStats
    {
        int gold;
        int objectives;

        public int Gold { get => gold ; set => gold = value; }
        public int Objectives { get => objectives; set => objectives = value; }

        public StatsMOBA()
        {
            this.Wins = 0;
            this.Losses = 0;
            this.Rating = 0;
            this.Description = "Default moba description";
            this.gold = 0;
            this.objectives = 0;
        }
    }
}
