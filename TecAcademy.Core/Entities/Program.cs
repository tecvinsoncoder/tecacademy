namespace TecAcademy.Core.Entities
{
    public class Program : Entity
    {
        public string Name {set; get;} = string.Empty;
        public Guid CourseId {set; get;}
    }
}