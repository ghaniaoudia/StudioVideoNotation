using System;
using System.Collections.Generic;

namespace Devon4Net.Domain.Entities.Models
{
    public partial class Prestation
    {
        public Prestation()
        {
            Notation = new HashSet<Notation>();
        }

        public int IdPrestation { get; set; }
        public int? IdClient { get; set; }
        public string TitrePrestation { get; set; }
        public DateTime? DateSaisie { get; set; }
        public string Commentaire { get; set; }
        public DateTime DateCreation { get; set; }
        public DateTime? DateModification { get; set; }

        public Client IdClientNavigation { get; set; }
        public ICollection<Notation> Notation { get; set; }
    }
}
