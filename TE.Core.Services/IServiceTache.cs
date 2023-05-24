using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TE.Core.Domain;

namespace TE.Core.Services
{
    public interface IServiceTache
    {

        public IList<Tache> getTacheBymember(string m);

        public IList<Tache> gettacheAverage(DateTime db , DateTime df );

        public IList<Tache> getTachebyProjet(Projet p);

    }
}
