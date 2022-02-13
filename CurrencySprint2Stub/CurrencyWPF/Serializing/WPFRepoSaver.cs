using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using Currency;
using CurrencyWPF.ViewModels;

namespace CurrencyWPF.Serializing
{
    public class WPFRepoSaver : RepoSaver
    {
        public string Path { get; set; }

        public WPFRepoSaver()
        {
            Path = @"currencyrepotext.txt";
        }

        public bool SaveTo()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream iostream = new FileStream(this.Path, FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(iostream, currencyRepo);
            iostream.Close();
            return true;
        }
        
        public WPFCurrencyRepo Load()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(Path,
                                      FileMode.Open,
                                      FileAccess.Read,
                                      FileShare.Read);

            if (stream.Length == 0)
            {
                return new WPFCurrencyRepo(new CurrencyRepo());
            }

            WPFCurrencyRepo repo = (WPFCurrencyRepo)formatter.Deserialize(stream);
            stream.Close();
            return repo;
        }
    }
}
