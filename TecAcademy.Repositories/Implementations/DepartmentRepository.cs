using TecAcademy.Core.Entities;
using TecAcademy.Core.Interfaces;

namespace TecAcademy.Repositories.Implementations
{
    public class DepartmentRepository : IDepartmentRepository
    {
        public Task<Department> Add(Department department)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Guid departmentId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Department>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Department> GetById(Guid departmentId)
        {
            throw new NotImplementedException();
        }

        public Task<Department> Update(Department department)
        {
            throw new NotImplementedException();
        }
    }
}