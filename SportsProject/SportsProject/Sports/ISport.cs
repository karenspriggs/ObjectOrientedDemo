using System;
using System.Collections.Generic;
using System.Text;
using SportsProject.Matches;
using SportsProject.Teams;

namespace SportsProject.Sports
{
    public interface ISport
    {
        List<ITeam> Teams { get; set; }
        List<IMatch> Matches { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        int TeamSize { get; set; }
    }
}
