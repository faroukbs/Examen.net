using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE.Core.Domain
{
    public class Sprint
    {
        public int Id { get; set; }
        [StringLength(150)]
        public string Description { get; set; }

        public DateTime DateDebut { get; set; }

        public virtual IList<Tache> Taches { get; set; }

        public virtual Projet Projet { get; set; }

    }
}
