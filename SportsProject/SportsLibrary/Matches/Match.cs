using System;
using System.Collections.Generic;
using System.Text;
using SportsProject.Teams;

namespace SportsProject.Matches
{
    public class Match : IMatch
    {
        ITeam team1;
        ITeam team2;
        string results;
        DateTime matchtime;

        public ITeam Team1 { get => team1; set => team1 = value; }
        public ITeam Team2 { get => team2; set => team2 = value; }
        public string Results { get => results; set => results = value; }
        public DateTime MatchTime { get => matchtime; set => matchtime = value; }

        public Match(ITeam team1, ITeam team2)
        {
            this.team1 = team1;
            this.team2 = team2;
            results = "Match Ongoing";
            SetTime();
        }

        public void SetTime()
        {
            MatchTime = DateTime.Now;
        }

        public string DetermineWinner(int score1, int score2)
        {
            if (score1 > score2)
            {
                team1.TeamWins();
                //team1.UpdateRating();
                return $"On {MatchTime}, {team1.Name} and {team2.Name} played against each other. {team1.Name} won!";
            }
            else
            {
                if (score1 < score2)
                {
                    team2.TeamWins();
                    //team2.UpdateRating();
                    return $"On {MatchTime}, {team1.Name} and {team2.Name} played against each other. {team2.Name} won!";
                }
                else
                {
                    //if they tie i dont even known
                    team1.TeamWins();
                    //team1.UpdateRating();
                    team2.TeamWins();
                    //team2.UpdateRating();
                    return $"On {MatchTime}, {team1.Name} and {team2.Name} played against each other. The teams had a draw!";
                }
            }
        }
    }
}
