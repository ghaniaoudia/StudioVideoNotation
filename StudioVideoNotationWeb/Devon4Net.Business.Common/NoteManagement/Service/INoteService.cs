using Devon4Net.Business.Common.NoteManagement.Dto;
using Devon4Net.Business.Common.PrestationManagement.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Devon4Net.Business.Common.NoteManagement.Service
{
    public interface INoteService
    {
        NoteDto addNote(NoteDto note);

    }
}
