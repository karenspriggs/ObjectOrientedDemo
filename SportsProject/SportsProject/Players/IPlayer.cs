using System;
using System.Collections.Generic;
using System.Text;
using SportsProject.Stats;
using SportsProject.Sports;

namespace SportsProject.Players
{
    public interface IPlayer
    {
        IStats PlayerStats { get; set; }
        string Name { get; set; }
        string Details { get; set; }
        int ID { get; set; }

        void UpdateDetails();
        void UpdateStats();
        void PlayerWins();
        void PlayerLoses();
    }
}
