using System;
using System.Collections.Generic;
using System.Text;

namespace SportsProject.Stats
{
    public interface IStats
    {
        int Wins { get; set; }
        int Losses { get; set; }
        int Rating { get; set; }
        string Description { get; set; }
    }
}
