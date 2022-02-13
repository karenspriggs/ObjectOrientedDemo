using System;
using System.Collections.Generic;
using System.Text;
using SportsProject.Players;
using SportsProject.Stats;

namespace SportsProject.Players
{
    public class PlayerMOBA : Player
    {
        string position;
        string main;

        public string Position { get => position; set => position = value; }
        public string Main { get => main; set => main = value; }

        public PlayerMOBA(string name, int id, string position, string main)
        {
            this.Name = name;
            this.ID = id;
            this.PlayerStats = new StatsMOBA();
            this.main = main;
            this.position = position;
            UpdateDetails();
        }

        public virtual void UpdateDetails()
        {
            string message = $"{Name}: {ID} {position} {main}";

            this.Details = message;
        }
    }
}
