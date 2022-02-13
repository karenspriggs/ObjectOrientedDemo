using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsWPF.Models.Serialization
{
    public interface ISave
    {
        void Save(ISave repo);
        void Load();
    }
}
