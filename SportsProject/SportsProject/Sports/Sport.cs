using System;
using System.Collections.Generic;
using System.Text;
using SportsProject.Matches;
using SportsProject.Teams;

namespace SportsProject.Sports
{
    public class Sport : ISport
    {
        List<ITeam> teams;
        List<IMatch> matches;
        string name;
        string description;
        int teamsize;

        public List<ITeam> Teams { get => teams; set => teams = value; }
        public List<IMatch> Matches { get => matches; set => matches = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public int TeamSize { get => teamsize; set => teamsize = value; }
    }
}
