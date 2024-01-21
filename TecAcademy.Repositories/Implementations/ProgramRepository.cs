using TecAcademy.Core.Entities;
using TecAcademy.Core.Interfaces;

namespace TecAcademy.Repositories.Implementations
{
    public class ProgramRepository : IProgramRepository
    {
        public Task<Program> Add(Program program)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Guid programId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Program>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Program> GetById(Guid programId)
        {
            throw new NotImplementedException();
        }

        public Task<Program> Update(Program program)
        {
            throw new NotImplementedException();
        }
    }
}