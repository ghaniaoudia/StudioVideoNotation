using AutoMapper;
using Devon4Net.Business.Common.NoteManagement.Dto;
using Devon4Net.Business.Common.NoteManagement.Service;
using Devon4Net.Business.Common.PrestationManagement.Dto;
using Devon4Net.Infrastructure.MVC.Controller;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Devon4Net.Business.Common.NoteManagement.Controller
{

    public class NoteController : Devon4NetController
    {
        private INoteService _NoteService;

        public NoteController(INoteService noteService, ILogger<NoteController> logger, IMapper mapper): base(logger, mapper)
        {
            _NoteService = noteService;
        }
  
        
        [HttpPost]
        [Route("api/notation")]
        [AllowAnonymous]
        [EnableCors("CorsPolicy")]
        public IActionResult addNote([FromBody]NoteDto newNote)
        {
            if (newNote == null)
            {
                return BadRequest();
            }
            NoteDto createdNote = _NoteService.addNote(newNote);
            return Ok(createdNote);

        }
    }
   

}

