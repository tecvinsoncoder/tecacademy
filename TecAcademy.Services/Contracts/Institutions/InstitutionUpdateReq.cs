namespace TecAcademy.Services.Contracts.Institutions
{
    public class InstitutionUpdateReq : InstitutionCreateReq
    {     
        public Guid Id { get; set; }
    }
}