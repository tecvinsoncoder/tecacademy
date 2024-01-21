using FluentValidation;

namespace TecAcademy.Services.Contracts.Institutions
{
    public class InstitutionCreateReqValidator : AbstractValidator<InstitutionCreateReq>
    {
        public InstitutionCreateReqValidator()
        {
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
