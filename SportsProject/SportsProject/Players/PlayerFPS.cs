using System;
using System.Collections.Generic;
using System.Text;
using SportsProject.Players;
using SportsProject.Stats;

namespace SportsProject.Players
{
    public class PlayerFPS : Player
    {
        string role;

        public string Role { get => role; set => role = value; }

        public PlayerFPS(string name, int id, string role)
        {
            this.Name = name;
            this.ID = id;
            this.PlayerStats = new StatsFPS();
            this.Role = role;
            UpdateDetails();
        }

        public override void UpdateDetails()
        {
            string message = $"{Name}: {ID} {role}";

            this.Details = message;
        }
    }
}
