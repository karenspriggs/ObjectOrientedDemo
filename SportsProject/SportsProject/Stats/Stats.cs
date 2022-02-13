using System;
using System.Collections.Generic;
using System.Text;

namespace SportsProject.Stats
{
    public class Stats: IStats
    {
        int wins;
        int losses;
        int rating;
        string description;

        public int Wins { get => wins; set => wins = value; }
        public int Losses { get => losses; set => losses = value; }
        public int Rating { get => rating; set => rating = value; }
        public string Description { get => description; set => description = value; }
    }
}
