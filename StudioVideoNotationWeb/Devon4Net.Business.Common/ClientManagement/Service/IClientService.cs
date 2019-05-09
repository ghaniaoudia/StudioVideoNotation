using Devon4Net.Business.Common.ClientManagement.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Devon4Net.Business.Common.ClientManagement.Service
{
    public interface IClientService
    {
        List<ClientDto> GetClients();//GetClients
        ClientDto CreateClient(ClientDto client);//post
    }
}
