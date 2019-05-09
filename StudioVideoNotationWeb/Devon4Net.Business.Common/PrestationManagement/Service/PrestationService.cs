using System;

using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Devon4Net.Business.Common.PrestationManagement.Dto;
using Devon4Net.Domain.Entities;
using Devon4Net.Domain.Entities.Models;
using Devon4Net.Domain.UnitOfWork.Pagination;
using Devon4Net.Domain.UnitOfWork.Service;
using Devon4Net.Domain.UnitOfWork.UnitOfWork;


namespace Devon4Net.Business.Common.PrestationManagement.Service
{
    public class PrestationService : Service<ModelContext>, IPrestationService
    {
        private IMapper Mapper { get; set; }
        public PrestationService(IUnitOfWork<ModelContext> unitOfWork, IMapper mapper) : base(unitOfWork)
        {
            Mapper = mapper;
        }


        public List<PrestationDto> GetAllPrestations()
        {
            var prestations = UoW.Repository<Prestation>().GetAll();

            return Mapper.Map<List<PrestationDto>>(prestations);
        }

        public PrestationDto GetPrestationById(int id)
        {
            Prestation prestation = UoW.Repository<Prestation>().Get(p => p.IdPrestation == id);
            return Mapper.Map<PrestationDto>(prestation);
        } 
    }
}
