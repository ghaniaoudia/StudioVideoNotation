using Devon4Net.Business.Common.PrestationManagement.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Devon4Net.Business.Common.PrestationManagement.Service
{
    public interface IPrestationService
    {
        List<PrestationDto> GetAllPrestations();
        PrestationDto GetPrestationById(int id);


    }
}