using System;
using System.Collections.Generic;
using System.Text;

namespace SportsProject.Stats
{
    [Serializable]
    public class Stats: IStats
    {
        int wins;
        int losses;
        double rating;
        string description;

        public int Wins { get => wins; set => wins = value; }
        public int Losses { get => losses; set => losses = value; }
        public double Rating { get => rating; set => rating = value; }
        public string Description { get => description; set => description = value; }

        public void MakeDescription()
        {
            Description = $"This player has won {Wins} times and lost {Losses} times.";
        }
    }
}
