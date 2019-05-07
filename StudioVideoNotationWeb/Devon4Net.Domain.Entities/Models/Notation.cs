using System;
using System.Collections.Generic;

namespace Devon4Net.Domain.Entities.Models
{
    public partial class Notation
    {
        public int IdNotation { get; set; }
        public int? IdPrestation { get; set; }
        public int? IdClient { get; set; }
        public int Note { get; set; }
        public string CommentaireNotation { get; set; }
        public DateTime DateCreation { get; set; }
        public DateTime? DateModification { get; set; }

        public Client IdClientNavigation { get; set; }
        public Prestation IdPrestationNavigation { get; set; }
    }
}
