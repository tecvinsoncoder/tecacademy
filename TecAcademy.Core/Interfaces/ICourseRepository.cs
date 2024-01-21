using TecAcademy.Core.Entities;

namespace TecAcademy.Core.Interfaces
{
    public interface ICourseRepository
    {
        Task<Course> Add(Course course);
        Task<Course> Update(Course course);
        Task<Course> GetById(Guid courseId);
        Task<List<Course>> GetAll();
        Task<bool> Delete(Guid courseId);
    }
}