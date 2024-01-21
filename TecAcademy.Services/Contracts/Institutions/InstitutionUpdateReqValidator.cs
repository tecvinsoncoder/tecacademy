using FluentValidation;

namespace TecAcademy.Services.Contracts.Institutions
{
    public class InstitutionUpdateReqValidator : AbstractValidator<InstitutionUpdateReq>
    {
        public InstitutionUpdateReqValidator() 
        {
            RuleFor(m => m.Id)
                .NotEmpty()
                .WithMessage("Id is required");

            RuleFor(m => m.Name)
                .NotEmpty()
                .WithMessage("Name is required");

            RuleFor(m => m.City)
                .NotEmpty()
                .WithMessage("City is required");

            RuleFor(m => m.State)
                .NotEmpty()
                .WithMessage("State is required");

            RuleFor(m => m.Country)
                .NotEmpty()
                .WithMessage("Country is required");

        }
    }
}
