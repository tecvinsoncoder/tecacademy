namespace TecAcademy.Services.Contracts.Institutions
{
    public class InstitutionDto
    {
        public Guid Id {set;get;}
        public string Name {set; get;} = string.Empty;
        public string City {set; get;} = string.Empty;
        public string State {set; get;} = string.Empty;
        public string Country {set; get;} = string.Empty;

    }
}