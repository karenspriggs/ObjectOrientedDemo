using System;
using System.Collections.Generic;
using System.Text;
using SportsProject.Players;
using SportsProject.Stats;

namespace SportsProject.Teams
{
    public interface ITeam
    {
        int Size { get; set; }
        string Name { get; set; }
        IPlayer[] Lineup { get; set; }
        IStats TeamStats { get; set; }

        void UpdateDescription();
        void TeamWins();
        void TeamLoses();
        void UpdatePlayerRating(int change);
        void UpdateRating();
        void AddPlayer(IPlayer p, int index);
    }
}
