using System;
using System.Collections.Generic;
using System.Text;

namespace SportsProject.Stats
{
    [Serializable]
    public class TeamStats: Stats
    {
        public TeamStats()
        {
            this.Wins = 0;
            this.Losses = 0;
            this.Rating = 0;
            this.Description = "Default team description";
        }
    }
}
