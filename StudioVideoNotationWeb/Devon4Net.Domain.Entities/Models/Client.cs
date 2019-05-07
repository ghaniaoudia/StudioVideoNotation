using System;
using System.Collections.Generic;

namespace Devon4Net.Domain.Entities.Models
{
    public partial class Client
    {
        public Client()
        {
            Notation = new HashSet<Notation>();
            Prestation = new HashSet<Prestation>();
        }

        public int IdClient { get; set; }
        public string NomClient { get; set; }
        public string PrenomClient { get; set; }
        public string EmailClient { get; set; }
        public DateTime DateCreation { get; set; }
        public DateTime? DateModification { get; set; }

        public ICollection<Notation> Notation { get; set; }
        public ICollection<Prestation> Prestation { get; set; }
    }
}
