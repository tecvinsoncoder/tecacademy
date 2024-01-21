using TecAcademy.Core.Entities;
using TecAcademy.Services.Contracts.Institutions;

namespace TecAcademy.Services.Extension
{
    public static class InstitutionExtensions
    {
        public static Institution AsEntity(this InstitutionCreateReq req)
        {
            return new Institution 
            {
                City = req.City,
                Country = req.Country,
                CreatedBy = "Me",
                State = req.State,
                Name = req.Name,
                DateCreated = DateTime.UtcNow
            };
        }

        public static Institution AsEntity(this InstitutionUpdateReq req)
        {
            return new Institution
            {
                Id = req.Id,
                City = req.City,
                Country = req.Country,
                ModifiedBy = "Me",
                State = req.State,
                Name = req.Name,
                DateModified = DateTime.UtcNow
            };
        }

        public static InstitutionDto AsDto(this Institution entity)
        {
            return new InstitutionDto
            {
                Id = entity.Id,
                City = entity.City,
                Country = entity.Country,
                State = entity.State,
                Name = entity.Name
            };
        }

        public static List<InstitutionDto> AsDtos(this List<Institution> entities)
        {
            var institutionDtos = new List<InstitutionDto>();  

            foreach (Institution entity in entities)
            {
                institutionDtos.Add(entity.AsDto());
            }

            return institutionDtos;
        }
    }
}