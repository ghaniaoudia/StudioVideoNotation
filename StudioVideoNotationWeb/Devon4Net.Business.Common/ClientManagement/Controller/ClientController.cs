using AutoMapper;
using Devon4Net.Business.Common.ClientManagement.Dto;
using Devon4Net.Business.Common.ClientManagement.Service;
using Devon4Net.Infrastructure.MVC.Controller;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Devon4Net.Business.Common.ClientManagement.Controller
{
    public class ClientController: Devon4NetController
    {
        private IClientService _clientService;

        public ClientController(IClientService clientService, ILogger<ClientController> logger,
            IMapper mapper ) : base(logger, mapper)
        {
            _clientService = clientService;
        }

        [HttpGet]
        [Route("api/clients")]
        [EnableCors("CorsPolicy")]
        public IActionResult GetClients()
        {

            List<ClientDto> clients = _clientService.GetClients();
            if (clients == null)
            {
                return NotFound();
            }
            return Ok(clients);
        }

        [HttpPost]
        [Route("api/client")]
        [EnableCors("CorsPolicy")]
        public IActionResult CreateClient([FromBody]ClientDto newClient)
        {
            if (newClient == null)
            {
                return BadRequest();
            }
            ClientDto createdClient = _clientService.CreateClient(newClient);
            return Ok(createdClient);

        }
    }
}
