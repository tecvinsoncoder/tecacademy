namespace TecAcademy.Core.Entities
{
    public class Course : Entity
    {
        public string Name {set; get;} = string.Empty;
        public string Code {set; get;} = string.Empty;
        public Guid FacultyId {set;get;}
    }
}