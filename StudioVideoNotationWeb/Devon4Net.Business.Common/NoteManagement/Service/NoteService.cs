using Devon4Net.Domain.Entities;
using Devon4Net.Domain.UnitOfWork.Service;
using System;
using System.Collections.Generic;
using System.Text;
using Devon4Net.Domain.UnitOfWork.UnitOfWork;
using AutoMapper;
using Devon4Net.Business.Common.NoteManagement.Dto;
using Devon4Net.Domain.Entities.Models;

namespace Devon4Net.Business.Common.NoteManagement.Service

{
    public class NoteService : Service<ModelContext>, INoteService
    {
        private IMapper Mapper { get; set; }
        public NoteService(IUnitOfWork<ModelContext> unitOfWork, IMapper mapper) : base(unitOfWork)
        {
            Mapper = mapper;
        }
        public NoteDto addNote(NoteDto note)
        {

            Notation createdNote = UoW.Repository<Notation>().Create(Mapper.Map<Notation>(note));
            note.DateCreation = new DateTime();
            note.DateCreation = new DateTime();
            UoW.Commit();
            return Mapper.Map<NoteDto>(createdNote);
        }

    }
}

