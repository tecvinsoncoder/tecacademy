namespace TecAcademy.Core.Entities
{
    public class Department : Entity
    {
        public string Name {set; get;} = string.Empty;
        public string Code {set; get;} = string.Empty;
        public Guid FacultyId {set;get;}
        public Faculty? Faculty {set;get;}
        public ICollection<Course>? Courses {set; get;}
    }
}
