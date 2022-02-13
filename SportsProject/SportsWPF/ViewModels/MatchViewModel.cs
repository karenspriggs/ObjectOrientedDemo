using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using SportsProject.Matches;
using SportsProject.Teams;
using SportsProject.Sports;
using WPFSports.ViewModels.Commands;
using System.Windows.Input;
using System.Collections.ObjectModel;

namespace WPFSports.ViewModels
{
    public class MatchViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public IMatch Match { get; set; }
        public ITeam Team1 { get; set; }
        public ITeam Team2 { get; set; }
        public ITeam Winner { get; set; }
        public ISport SelectedSport { get; set; }
        public int Score1 { get; set; }
        public int Score2 { get; set; }
        public string Results { get; set; }
        public DateTime MatchTime { get; set; }
        public ICommand SetSport { get; set; }
        public ICommand SetTeams { get; set; }
        public ICommand StartMatch { get; set; }
        public ICommand SetTime { get; set; }

        public MatchViewModel()
        {
            this.SetSport = new WPFCommand(ExecuteSetSport, CanSetSport);
            this.StartMatch = new WPFCommand(ExecuteStartMatch, CanStartMatch);
            this.SetTime = new WPFCommand(ExecuteSetTime, CanSetTime);
            this.SetTeams = new WPFCommand(ExecuteSetTeams, CanSetTeams);
        }

        public bool CanSetSport(object parameter)
        {
            return true;
        }

        public bool CanStartMatch(object parameter)
        {
            return true;
        }

        public bool CanSetTeams(object parameter)
        {
            return true;
        }

        public bool CanSetTime(object parameter)
        {
            return true;
        }

        public void ExecuteSetSport(object parameter)
        {
            RaisePropertyChanged("SelectedSport");
        }

        public void ExecuteSetTime(object parameter)
        {
            Match.MatchTime = (MatchTime);
            RaisePropertyChanged("MatchTime");
        }

        public void ExecuteSetTeams(object parameter)
        {
            Match = new Match(Team1, Team2);
        }

        public void ExecuteStartMatch(object parameter)
        {
            RaisePropertyChanged("Score1");
            RaisePropertyChanged("Score2");
            Results = Match.DetermineWinner(Score1, Score2);
            RaisePropertyChanged("Results");
            RaisePropertyChanged("Winner");
        }

        public void RaisePropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
