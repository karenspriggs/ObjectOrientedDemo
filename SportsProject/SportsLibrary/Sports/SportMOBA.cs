using System;
using System.Collections.Generic;
using System.Text;
using SportsProject.Teams;
using SportsProject.Matches;

namespace SportsProject.Sports
{
    [Serializable]
    public class SportMOBA : Sport
    {
        public SportMOBA(string name, int teamsize) : base(name, teamsize)
        {
            /**
            this.Name = name;
            this.TeamSize = teamsize;
            this.Matches = new List<IMatch>();
            this.Teams = new List<ITeam>();
            **/
        }
    }
}
