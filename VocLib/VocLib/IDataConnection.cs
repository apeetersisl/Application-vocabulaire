using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VocLib.Objets;

namespace VocLib
{
    public interface IDataConnection
    {
        Mots CreateMot(Mots Model);
        Serie CreateSerie(Serie Model);

        List<string> GetSerieList();
        Serie GetSerieID(Serie Model);
        List<Mots> GetMots(Serie Model);

        Serie GetNumberMots(Serie Model);

        Stats GetStats(Stats stats);

        void AddStats(Stats stats);
    }
}
