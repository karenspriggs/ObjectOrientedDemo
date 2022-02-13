using System;
using System.Collections.Generic;
using System.Text;
using SportsProject.Sports;
using SportsProject.Players;
using SportsProject.Stats;

namespace SportsProject.Teams
{
    [Serializable]
    public class Team : ITeam
    {
        List<IPlayer> lineup;
        IStats teamstats; 
        int size;
        string name;

        public List<IPlayer> Lineup { get => lineup; set => lineup = value; }
        public IStats TeamStats { get => teamstats; set => teamstats = value; }
        public int Size { get => size; set => size = value; }
        public string Name { get => name; set => name = value; }

        // since sports have teams, the size is taken from the teamsize for the sport
        public Team(int size, string name)
        {
            this.size = size;
            this.lineup = new List<IPlayer>();
            this.teamstats = new TeamStats();
            this.name = name;
            LoadPlayers();
        } 

        public void LoadPlayers()
        {
            for (int i = 0; i < size; i++)
            {
                lineup.Add(new Player("Default Player", 0));
                
            }
        }

        // if a team wins, their score can go up
        public void TeamWins()
        {
            this.teamstats.Wins++;

            /**
            foreach(IPlayer p in lineup)
            {
                p.PlayerLoses();
            }
            **/
        }

        public void TeamLoses()
        {
            this.teamstats.Losses++;
            /**
            foreach (IPlayer p in lineup)
            {
                p.PlayerWins();
            }
            **/
        }

        // When a team wins, the players on it should have their ratings updated too
        public void UpdatePlayerRating(int change)
        {
            foreach(Player p in lineup)
            {
                p.PlayerStats.Rating += change;
            }
        }

        // the teams rating is linked to the combined rating of all the players
        // if a player is added or removed the rating of the team must change
        public void UpdateRating()
        {
            double total = 0;
            foreach (IPlayer p in Lineup)
            {
                total += p.PlayerStats.Rating;
            }

            teamstats.Rating = total;
        }

        // adding players to a certain spot at the team to replace others in the array
        // since it is about replacing players then there is no need for removing players
        public void AddPlayer(IPlayer p)
        {
            if (Lineup.Count < size)
            {
                Lineup.Add(p);
            }
        }

        public void RemovePlayer()
        {
            Lineup.Remove(Lineup[0]);
        }

        public void RemovePlayer(IPlayer p)
        {
            Lineup.Remove(p);
        }
    }
}
