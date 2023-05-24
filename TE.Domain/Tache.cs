using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE.Core.Domain
{
    public class Tache
    {
        public string Titre { get; set; }
        public EtatTache Etat { get; set; }

        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }

        public virtual Sprint Sprint { get; set; }
        public virtual Member Member { get; set; }

        public int SprintKey { get; set; }

        public string MemberKey { get; set; }
    }
}
