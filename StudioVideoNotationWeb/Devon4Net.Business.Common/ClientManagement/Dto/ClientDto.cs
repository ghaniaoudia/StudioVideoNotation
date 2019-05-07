using Devon4Net.Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Devon4Net.Business.Common.ClientManagement.Dto
{
    public class ClientDto
    {
        public int IdClient { get; set; }
        public string NomClient { get; set; }
        public string PrenomClient { get; set; }
        public string EmailClient { get; set; }
        public DateTime DateCreation { get; set; }
        public DateTime? DateModification { get; set; }

    }
}
