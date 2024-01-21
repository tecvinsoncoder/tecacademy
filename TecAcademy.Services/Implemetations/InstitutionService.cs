using TecAcademy.Services.Contracts.Institutions;
using TecAcademy.Services.Interfaces;
using TecAcademy.Core.Interfaces;
using TecAcademy.Services.Extension;

namespace TecAcademy.Services.Implemetations
{
    public class InstitutionService : IInstitutionService
    {
        private readonly IInstitutionRepository _repository;
        public InstitutionService(IInstitutionRepository repository)
        {
            _repository = repository;  
        }
        public InstitutionRsp<InstitutionDto> Create(InstitutionCreateReq req)
        {
            var newInstituion = req.AsEntity();

            _repository.Add(newInstituion);

            return new InstitutionRsp<InstitutionDto>
            {
                Code = "200",
                Messgae = string.Empty
            };
        }

        public async Task<InstitutionRsp<bool>> Delete(Guid id)
        {
            var result = await _repository.Delete(id);

            return new InstitutionRsp<bool>
            {
                Code = "200",
                Messgae = string.Empty,
                Result = result   
            };
        }

        public async Task<InstitutionRsp<List<InstitutionDto>>> GetAll()
        {
            var result = await _repository.GetAll();

            return new InstitutionRsp<List<InstitutionDto>>
            {
                Code = "200",
                Messgae = string.Empty,
                Result = result.AsDtos()
            };
        }

        public async Task<InstitutionRsp<InstitutionDto>> GetById(Guid instiutionId)
        {
            var result = await _repository.GetById(instiutionId);

            if(result == null)
            {
                return new InstitutionRsp<InstitutionDto>
                {
                    Code = "Institution.NotFound",
                    Messgae = "Institution was not found",
                };
            }

            return new InstitutionRsp<InstitutionDto>
            {
                Code = "200",
                Messgae = string.Empty,
                Result = result.AsDto()
            };
        }

        public async Task<InstitutionRsp<InstitutionDto>> Update(InstitutionUpdateReq req)
        {
            var toUpdate = req.AsEntity();

            var update =  await _repository.Update(toUpdate);

            return new InstitutionRsp<InstitutionDto>
            {
                Code = "200",
                Messgae = string.Empty,
                Result = update.AsDto()
            };
        }
    }
}