using AutoMapper;
using Devon4Net.Business.Common.NoteManagement.Dto;
using Devon4Net.Business.Common.PrestationManagement.Dto;
using Devon4Net.Domain.Entities.Models;

namespace Devon4Net.Business.Common
{
    public class AutomapperProfile : Profile 
    {
        /// <summary>
        /// Put automapper profile here
        /// </summary>
        public AutomapperProfile()
        {
            CreateMap<Prestation, PrestationDto>()
            .ReverseMap();

            CreateMap<Notation, NoteDto>()
            .ReverseMap();
        }
    }
}
