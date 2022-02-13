using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using SportsWPF.Models.Serialization;
using System.Collections.ObjectModel;
using SportsProject.Teams;

namespace SportsWPF.Models.Serialization
{
    [Serializable]
    public class TeamSaver
    {
        public ObservableCollection<ITeam> TeamRepo { get; set; }
        public string Path { get; set; }

        public TeamSaver()
        {
            this.TeamRepo = new ObservableCollection<ITeam>();
            Path = @"teamstext.txt";
        }

        public void Save()
        {
            IFormatter formatter = new BinaryFormatter();

            Stream iostream = new FileStream(this.Path, FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(iostream, TeamRepo);
            iostream.Close();
        }

        public ObservableCollection<ITeam> Load()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream iostream = new FileStream(Path,
                                      FileMode.Open,
                                      FileAccess.Read,
                                      FileShare.Read);

            if (iostream.Length == 0)
            {
                return new ObservableCollection<ITeam>();
            }

            ObservableCollection<ITeam> teams = (ObservableCollection<ITeam>)formatter.Deserialize(iostream);
            iostream.Close();
            return teams;
        }
    }
}
