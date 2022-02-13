using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Windows.Input;
using SportsProject.Teams;
using WPFSports.ViewModels.Commands;
using System.Windows.Input;
using SportsProject.Players;
using SportsProject.Sports;
using System.Collections.ObjectModel;
using SportsWPF.Models.Serialization;

namespace WPFSports.ViewModels
{
    [Serializable]

    public class TeamViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<ITeam> CurrentTeams { get; set; }
        public ObservableCollection<IPlayer> TeamPlayers { get; set; }
        public string NewTeamName { get; set; }
        public string NewPlayerName { get; set; }
        public int NewPlayerID { get; set; }
        public TeamSaver teamSaver { get; set; }

        //Commands
        public ISport SelectedSport { get; set; }
        public ITeam SelectedTeam { get; set; }
        public ITeam RemovedTeam { get; set; }
        public IPlayer SelectedPlayer { get; set; }
        public ICommand EditTeam { get; set; }
        public ICommand AddTeam { get; set; }
        public ICommand RemoveTeam { get; set; }
        public ICommand SaveTeams { get; set; }
        public ICommand LoadTeams { get; set; }
        public ICommand AddPlayer { get; set; }
        public ICommand RemovePlayer { get; set; }
        public ICommand ShowPlayers { get; set; }
        public ICommand SelectSport { get; set; }
        public ICommand SelectPlayer { get; set; }
        public ICommand UpdatePlayer { get; set; }

        public TeamViewModel() {
            this.teamSaver = new TeamSaver();
            this.CurrentTeams = new ObservableCollection<ITeam>();
            this.TeamPlayers = new ObservableCollection<IPlayer>();

            this.SelectSport = new WPFCommand(ExecuteSelectSport, CanSelectSport);
            this.EditTeam = new WPFCommand(ExecuteEditTeam, CanEditTeam);
            this.AddTeam = new WPFCommand(ExecuteAddTeam, CanAddTeam);
            this.RemoveTeam = new WPFCommand(ExecuteRemoveTeam, CanRemoveTeam);
            this.ShowPlayers = new WPFCommand(ExecuteShowPlayers, CanShowPlayers);
            this.UpdatePlayer = new WPFCommand(ExecuteUpdatePlayer, CanUpdatePlayer);
            this.AddPlayer = new WPFCommand(ExecuteAddPlayer, CanAddPlayer);
            this.RemovePlayer = new WPFCommand(ExecuteRemovePlayer, CanRemovePlayer);

            this.SaveTeams = new WPFCommand(ExecuteSaveTeams, CanSaveTeams);
            this.LoadTeams = new WPFCommand(ExecuteLoadTeams, CanLoadTeams);
        }

        public bool CanSelectSport(object parameter)
        {
            return true;
        }

        public bool CanEditTeam(object parameter)
        {
            return true;
        }

        public bool CanAddTeam(object parameter)
        {
            return true;
        }

        public bool CanAddPlayer(object parameter)
        {
            return true;
        }

        public bool CanRemoveTeam(object parameter)
        {
            return true;
        }
        public bool CanRemovePlayer(object parameter)
        {
            return true;
        }

        public bool CanShowPlayers(object parameter)
        {
            return true;
        }

        public bool CanUpdatePlayer(object parameter)
        {
            return true;
        }

        public bool CanSaveTeams(object parameter)
        {
            return true;
        }

        public bool CanLoadTeams(object parameter)
        {
            return true;
        }

        public void ExecuteSelectSport(object parameter)
        {
            RaisePropertyChanged("SelectedSport");
        }

        public void ExecuteEditTeam(object parameter)
        {
            RaisePropertyChanged("CurrentTeam.Name");
        }

        public void ExecuteAddTeam(object parameter)
        {
            RaisePropertyChanged("NewTeamName");
            RaisePropertyChanged("CurrentTeams");
            this.CurrentTeams.Add(new Team(SelectedSport.TeamSize, NewTeamName));
            SelectedSport.Teams.Add(new Team(SelectedSport.TeamSize, NewTeamName));
            RaisePropertyChanged("CurrentTeams");
        }

        public void ExecuteAddPlayer(object parameter)
        {
            RaisePropertyChanged("NewPlayerName");
            RaisePropertyChanged("NewPlayerID");
            Player p = new Player(NewPlayerName, NewPlayerID);
            this.SelectedTeam.AddPlayer(p);
            TeamPlayers.Add(p);
            RaisePropertyChanged("TeamPlayers");
        }

        public void ExecuteRemoveTeam(object parameter)
        {
            SelectedSport.Teams.Remove(RemovedTeam);
            CurrentTeams.Remove(RemovedTeam);
            RaisePropertyChanged("CurrentTeams");
        }

        public void ExecuteRemovePlayer(object parameter)
        {
            this.SelectedTeam.RemovePlayer(SelectedPlayer);
            this.TeamPlayers.Remove(SelectedPlayer);
            RaisePropertyChanged("TeamPlayers");
        }

        public void ExecuteUpdatePlayer(object parameter)
        {
            RaisePropertyChanged("SelectedTeam");
            TeamPlayers.Clear();

            foreach (IPlayer p in SelectedTeam.Lineup)
            {
                //p.Name = "Default";
                TeamPlayers.Add(p);
            }

            RaisePropertyChanged("TeamPlayers");
        }

        public void ExecuteShowPlayers(object parameter)
        {
            RaisePropertyChanged("SelectedTeam");
            TeamPlayers.Clear();
            foreach (IPlayer p in SelectedTeam.Lineup)
            {
                //p.Name = "Default";
                TeamPlayers.Add(p);
            }
            RaisePropertyChanged("TeamPlayers");
        }

        public void ExecuteSaveTeams(object parameter)
        {
            foreach (ITeam t in CurrentTeams)
            {
                teamSaver.TeamRepo.Add(t);
            }
            teamSaver.Save();
        }

        public void ExecuteLoadTeams(object parameter)
        {
            CurrentTeams = teamSaver.Load();
            RaisePropertyChanged("CurrentTeams");
        }

        public void LoadTeamPlayers() 
        {
            foreach (IPlayer p in SelectedTeam.Lineup)
            {
                TeamPlayers.Add(p);
            }
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
