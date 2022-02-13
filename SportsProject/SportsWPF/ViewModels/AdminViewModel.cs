using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportsProject.Teams;
using System.ComponentModel;
using SportsProject.Sports;
using SportsProject.Teams;
using WPFSports.ViewModels;
using WPFSports.ViewModels.Commands;
using System.Windows.Input;

namespace WPFSports.ViewModels
{
    public class AdminViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public TeamViewModel TeamVM { get; set; }
        public MatchViewModel MatchVM { get; set; }
        public SportsViewModel SportsVM { get; set; }

        public AdminViewModel()
        {
            this.TeamVM = new TeamViewModel();
            this.MatchVM = new MatchViewModel();
            this.SportsVM = new SportsViewModel();
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
