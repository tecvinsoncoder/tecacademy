using System.ComponentModel.DataAnnotations;

namespace TecAcademy.Services.Contracts.Institutions
{
    public class InstitutionCreateReq
    {
        public string? Name {set; get;}
        public string? City {set; get;}
        public string State {set; get;} = string.Empty;
        public string Country {set; get;} = string.Empty;
    }
}