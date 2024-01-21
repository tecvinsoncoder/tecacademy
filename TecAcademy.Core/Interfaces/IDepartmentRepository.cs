using TecAcademy.Core.Entities;

namespace TecAcademy.Core.Interfaces
{
    public interface IDepartmentRepository
    {
        Task<Department> Add(Department department);
        Task<Department> Update(Department department);
        Task<Department> GetById(Guid departmentId);
        Task<List<Department>> GetAll();
        Task<bool> Delete(Guid departmentId); 
    }
}