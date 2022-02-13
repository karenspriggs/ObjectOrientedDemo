﻿using System;
using System.Collections.Generic;
using System.Text;
using SportsProject.Sports;
using SportsProject.Stats;

namespace SportsProject.Players
{
    [Serializable]

    public class Player : IPlayer
    {
        IStats playerstats;

        int id;
        string name;
        string details;

        public IStats PlayerStats { get; set; }
        public int ID { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Details { get => details; set => details = value; }

        // should be able to be overrided for specific details

        public Player(string name, int id)
        {
            PlayerStats = new PlayerStats();
            this.name = name;
            this.id = id;
        }

        public virtual void UpdateDetails()
        {
            string message = "";
            message += this.name;
            message += " ";
            message += this.id;
            message += ".";
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
