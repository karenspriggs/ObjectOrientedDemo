using System;
using System.Collections.Generic;
using System.Text;
using SportsProject.Sports;
using SportsProject.Stats;

namespace SportsProject.Players
{
    public class Player : IPlayer
    {
        IStats playerstats;

        int id;
        string name;
        string details;

        public IStats PlayerStats { get; set; }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }

        // should be able to be overrided for specific details
        public virtual void UpdateDetails()
        {
            string message = "";
            message += this.name;
            message += this.id;
            message += this.PlayerStats.Description;

            this.details = message;
        }

        public void PlayerWins()
        {
            this.PlayerStats.Wins++;
        }

        public void PlayerLoses()
        {
            this.PlayerStats.Losses++;
        }

        public void UpdateStats()
        {
            int total = PlayerStats.Wins + PlayerStats.Losses;
            this.PlayerStats.Rating = PlayerStats.Wins / total;
        }
    }
}
