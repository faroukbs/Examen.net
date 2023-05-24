using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TE.Core.Domain;
using TE.Core.Interfaces;

namespace TE.Core.Services
{
    public class ServiceTache : Service<Tache>, IServiceTache
    {
        public ServiceTache(IUnitOfWork uow) : base(uow)
        {
        }

        public IList<Tache> gettacheAverage(DateTime db, DateTime df)
        {
            return GetAll().Where(t =>  t.Etat== EtatTache.Fermee && t.DateDebut.Date == db.Date && t.DateDebut.Date == df.Date   ).ToList();
        }

        public IList<Tache> getTacheBymember(string m)
        {
          return  GetAll().Where(t=>t.Etat==EtatTache.EnCours && t.MemberKey==m).ToList();
        }

        public IList<Tache> getTachebyProjet(Projet p)
        {
            return GetAll().OrderBy(t=>t.Sprint.Projet==p).ToList();
        }
    }
}
