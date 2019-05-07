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
        private IClientService _ClientService;

        public ClientController(IClientService clientService, ILogger<ClientController> logger,
            IMapper mapper ) : base(logger, mapper)
        {
            _ClientService = clientService;
        }

        [HttpPost]
        [Route("api/client")]
        [AllowAnonymous]
        [EnableCors("CorsPolicy")]
        public IActionResult createClient([FromBody]ClientDto newClient)
        {
            if (newClient == null)
            {
                return BadRequest();
            }
            ClientDto createdClient = _ClientService.CreateClient(newClient);
            return Ok(createdClient);

        }
    }
}
