using TecAcademy.Core.Entities;

namespace TecAcademy.Core.Interfaces
{
    public interface IProgramRepository 
    {
        Task<Program> Add(Program program);
        Task<Program> Update(Program program);
        Task<Program> GetById(Guid programId);
        Task<List<Program>> GetAll();
        Task<bool> Delete(Guid programId);
    }
}