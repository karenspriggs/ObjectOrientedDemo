using System;
using System.Collections.Generic;
using System.Text;
using SportsProject.Teams;

namespace SportsProject.Matches
{
    public interface IMatch
    {
        ITeam Team1 { get; set; }
        ITeam Team2 { get; set; }
        string Results { get; set; }
        DateTime MatchTime { get; set; }

        void SetTime();
        string DetermineWinner(int score1, int score2);

    }
}
