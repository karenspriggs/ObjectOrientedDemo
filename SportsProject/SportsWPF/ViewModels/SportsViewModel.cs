using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Windows.Input;
using System.Collections.ObjectModel;
using System.ComponentModel;
using SportsProject.Sports;
using WPFSports.ViewModels;
using SportsProject.Teams;
using WPFSports.ViewModels.Commands;
using SportsWPF.Models.Serialization;

namespace WPFSports.ViewModels
{
    public class SportsViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<ISport> CurrentSports { get; set; }
        public string NewSportName { get; set; }
        public int NewSportSize { get; set; }
        public SportsSaver sportsSaver { get; set; }

        // Commands
        public ISport RemovedSport { get; set; }
        public ICommand SaveSports { get; set; }
        public ICommand LoadSports { get; set; }
        public ICommand AddSport { get; set; }
        public ICommand RemoveSport { get; set; }
        public ICommand AddFPS { get; set; }
        public ICommand AddMOBA { get; set; }

        public SportsViewModel()
        {
            this.sportsSaver = new SportsSaver();
            this.CurrentSports = new ObservableCollection<ISport>();
            CurrentSports.Add(new SportFPS("Overwatch", 6));
            CurrentSports.Add(new SportMOBA("League of Legends", 5));
            this.AddSport = new WPFCommand(ExecuteAddSport, CanAddSport);
            this.RemoveSport = new WPFCommand(ExecuteRemoveSport, CanRemoveSport);
            this.AddFPS = new WPFCommand(ExecuteAddFPS, CanAddFPS);
            this.AddMOBA = new WPFCommand(ExecuteAddMOBA, CanAddMOBA);
            this.AddSport = new WPFCommand(ExecuteAddSport, CanAddSport);
            this.SaveSports = new WPFCommand(ExecuteSaveSports, CanSaveSports);
            this.LoadSports = new WPFCommand(ExecuteLoadSports, CanLoadSports);
        }

        public bool CanAddSport(object parameter)
        {
            return true;
        }

        public bool CanAddFPS(object parameter)
        {
            return true;
        }

        public bool CanAddMOBA(object parameter)
        {
            return true;
        }

        public bool CanSaveSports(object parameter)
        {
            return true;
        }
        public bool CanLoadSports(object parameter)
        {
            return true;
        }

        public bool CanRemoveSport(object parameter)
        {
            return true;
        }

        public void ExecuteSaveSports(object parameter)
        {
            foreach (ISport s in CurrentSports) {
                sportsSaver.SportsRepo.Add(s);
            }
            sportsSaver.Save();
        }

        public void ExecuteLoadSports(object parameter)
        {
            CurrentSports = sportsSaver.Load();
            RaisePropertyChanged("CurrentSports");
        }

        public void ExecuteRemoveSport(object parameter)
        {
            this.CurrentSports.Remove(RemovedSport);
            RaisePropertyChanged("CurrentSports");
        }

        public void ExecuteAddSport(object parameter)
        {
            RaisePropertyChanged("NewSportName");
            RaisePropertyChanged("NewSportSize");
            this.CurrentSports.Add(new Sport(NewSportName, NewSportSize));
            RaisePropertyChanged("CurrentSports");
        }

        public void ExecuteAddFPS(object parameter)
        {
            RaisePropertyChanged("NewSportName");
            RaisePropertyChanged("NewSportSize");
            this.CurrentSports.Add(new SportFPS(NewSportName, NewSportSize));
            RaisePropertyChanged("CurrentSports");
        }

        public void ExecuteAddMOBA(object parameter)
        {
            RaisePropertyChanged("NewSportName");
            RaisePropertyChanged("NewSportSize");
            this.CurrentSports.Add(new SportMOBA(NewSportName, NewSportSize));
            RaisePropertyChanged("CurrentSports");
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
