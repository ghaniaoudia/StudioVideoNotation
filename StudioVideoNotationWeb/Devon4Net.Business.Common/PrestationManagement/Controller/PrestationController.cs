using System;
using System.Net;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Devon4Net.Infrastructure.MVC.Controller;
using System.Linq;
using Devon4Net.Business.Common.PrestationManagement.Service;
using Devon4Net.Business.Common.PrestationManagement.Dto;
using Microsoft.AspNetCore.Cors;

namespace Devon4Net.Business.Common.PrestationManagement.Controller

{

    public class PrestationController : Devon4NetController
    {
        private IPrestationService _PrestationService;


        public PrestationController(IPrestationService prestationService, ILogger<PrestationController> logger, IMapper mapper) : base(logger, mapper)
        {
            _PrestationService = prestationService;
        }

        [HttpGet]
        [Route("api/prestation")]
        [EnableCors("CorsPolicy")]
        public IActionResult GetAllPrestations()
        {

            List<PrestationDto> prestation = _PrestationService.GetAllPrestations();
            if (prestation == null)
            {
                return NotFound();
            }
            return Ok(prestation);
        }

        /// <summary>
        /// get prestation by id
        /// </summary>
        /// <param name="id">Id Prestation</param>
        /// <returns></returns>
        [Route("api/prestation/{id}")]
        [HttpGet]
        [EnableCors("CorsPolicy")]
        public IActionResult GetPrestation(int id)
        {

            PrestationDto  prestation =_PrestationService.GetPrestationById(id);
            if(prestation == null)
            {
                return NotFound();
            }
            return Ok(prestation);
        }

    }
}
