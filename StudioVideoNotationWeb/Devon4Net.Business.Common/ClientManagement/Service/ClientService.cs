using AutoMapper;
using Devon4Net.Business.Common.ClientManagement.Dto;
using Devon4Net.Domain.Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Devon4Net.Domain.UnitOfWork.UnitOfWork;
using Devon4Net.Domain.UnitOfWork.Service;
using System;
using System.Collections.Generic;
using System.Text;
using Devon4Net.Domain.Entities;

namespace Devon4Net.Business.Common.ClientManagement.Service
{
    public class ClientService : Service<ModelContext>, IClientService
    {
        private IMapper Mapper { get; set; }
        public ClientService(IUnitOfWork<ModelContext> unitOfWork, IMapper mapper) : base(unitOfWork)
        {
            Mapper = mapper;
        }

        public List<ClientDto> GetClients()
        {
            var clients = UoW.Repository<Client>().GetAll();
            return Mapper.Map<List<ClientDto>>(clients);
        }
        public ClientDto CreateClient(ClientDto client)
        {

            Client createdClient = UoW.Repository<Client>().Create(Mapper.Map<Client>(client));
            client.DateCreation = new DateTime();
            client.DateCreation = new DateTime();
            UoW.Commit();
            return Mapper.Map<ClientDto>(createdClient);
        }
    }
}
