namespace TecAcademy.Core.Entities
{
    public class Institution : Entity
    {
        public string Name {set; get;} = string.Empty;
        public string City {set; get;} = string.Empty;
        public string State {set; get;} = string.Empty;
        public string Country {set; get;} = string.Empty;

        public ICollection<Faculty>? Faculties {set; get;} 
    }
}