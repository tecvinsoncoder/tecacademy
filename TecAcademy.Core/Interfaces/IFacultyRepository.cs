using TecAcademy.Core.Entities;

namespace TecAcademy.Core.Interfaces
{
    public interface IFacultyRepository
    {
        Task<Faculty> Add(Faculty faculty);
        Task<Faculty> Update(Faculty faculty);
        Task<Faculty> GetById(Guid facultyId);
        Task<Faculty> GetByInstitutionId(Guid institutionId);
        Task<List<Faculty>> GetAll();
        Task<bool> Delete(Guid facultyId);
    }
}