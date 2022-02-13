using System;
using System.Collections.Generic;
using System.Text;

namespace SportsProject.Stats
{
    [Serializable]
    public class PlayerStats : Stats
    {
        public PlayerStats()
        {
            Wins = 0;
            Losses = 0;
            Rating = 0;
            MakeDescription();
        }
    }
}
