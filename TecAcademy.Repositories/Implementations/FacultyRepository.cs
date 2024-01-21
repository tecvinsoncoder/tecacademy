using TecAcademy.Core.Entities;
using TecAcademy.Core.Interfaces;

namespace TecAcademy.Repositories.Implementations
{
    public class FacultyRepository : IFacultyRepository
    {
        public Task<Faculty> Add(Faculty faculty)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Guid facultyId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Faculty>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Faculty> GetById(Guid facultyId)
        {
            throw new NotImplementedException();
        }

        public Task<Faculty> GetByInstitutionId(Guid institutionId)
        {
            throw new NotImplementedException();
        }

        public Task<Faculty> Update(Faculty faculty)
        {
            throw new NotImplementedException();
        }
    }
}