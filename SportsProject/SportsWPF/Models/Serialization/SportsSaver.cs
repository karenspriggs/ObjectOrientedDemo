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
using SportsProject.Sports;

namespace SportsWPF.Models.Serialization
{
    [Serializable]
    public class SportsSaver
    {
        public ObservableCollection<ISport> SportsRepo { get; set; }

        public string Path { get; set; }

        public SportsSaver()
        {
            this.SportsRepo = new ObservableCollection<ISport>();
            Path = @"sportstext.txt";
        }

        public void Save()
        {
            IFormatter formatter = new BinaryFormatter();

            Stream iostream = new FileStream(this.Path, FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(iostream, SportsRepo);
            iostream.Close();
        }

        public ObservableCollection<ISport> Load()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream iostream = new FileStream(Path,
                                      FileMode.Open,
                                      FileAccess.Read,
                                      FileShare.Read);

            if (iostream.Length == 0)
            {
                return new ObservableCollection<ISport>();
            }

            ObservableCollection<ISport> sports = (ObservableCollection<ISport>)formatter.Deserialize(iostream);
            iostream.Close();
            return sports;
        }
    }
}
