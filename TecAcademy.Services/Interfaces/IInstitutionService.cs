using TecAcademy.Services.Contracts.Institutions;

namespace TecAcademy.Services.Interfaces
{
    public interface IInstitutionService
    {
        InstitutionRsp<InstitutionDto> Create(InstitutionCreateReq req);
        Task<InstitutionRsp<InstitutionDto>> GetById(Guid instiutionId);
        Task<InstitutionRsp<List<InstitutionDto>>> GetAll();

        Task<InstitutionRsp<bool>> Delete(Guid id);
        Task<InstitutionRsp<InstitutionDto>> Update(InstitutionUpdateReq req);
    }
}