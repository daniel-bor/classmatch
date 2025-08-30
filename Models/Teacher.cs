namespace ClassMatch.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public Guid TeacherIdentifier { get; set; } // Identificador único
        public List<Specialty> Specialties { get; set; }
        public List<Section> Sections { get; set; }
    }

    public class Specialty
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
