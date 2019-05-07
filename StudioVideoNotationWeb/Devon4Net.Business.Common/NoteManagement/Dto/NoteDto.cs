using Devon4Net.Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Devon4Net.Business.Common.NoteManagement.Dto
{
    public class NoteDto
    {
        
        public int? IdPrestation { get; set; }
        public int? IdClient { get; set; }
        public int Note { get; set; }
        public DateTime DateCreation { get; set; }
        public DateTime? DateModification { get; set; }

    }
}
