using TecAcademy.Core.Entities;
using TecAcademy.Core.Interfaces;
using TecAcademy.Repositories.Data;
using Microsoft.EntityFrameworkCore;

namespace TecAcademy.Repositories.Implementations
{
    public class InstitutionRepository : IInstitutionRepository
    {
        private AcademyContext _academyContext;
        public InstitutionRepository(AcademyContext academyContext)
        {
            _academyContext = academyContext;
        }
        public async Task<Institution> Add(Institution institution)
        {
            _academyContext.Add(institution);
            _academyContext.SaveChanges();
            return await Task.FromResult(institution);
        }

        public async Task<bool> Delete(Guid institutionId)
        {
            var institution = await _academyContext
                            .Institutions
                            .Where(m => m.Id == institutionId)
                            .FirstOrDefaultAsync();
                            
            _academyContext
            .Institutions
            .Remove(institution ?? new Institution());

           return _academyContext.SaveChanges() > 0 ? true : false;
        }

        public async Task<List<Institution>> GetAll()
        {
            return await Task.FromResult( _academyContext
            .Institutions
            .ToList());
        }

        public async Task<Institution?> GetById(Guid institutionId)
        {
            Institution? institution = await _academyContext
                            .Institutions
                            .Where(m => m.Id == institutionId)
                            .FirstOrDefaultAsync();

            return institution;
        }

        public async Task<Institution> Update(Institution institution)
        {
            var update = _academyContext.Institutions.Update(institution);
            _academyContext.SaveChanges();
            
            return await Task.FromResult(institution);
        }
    }
}