namespace ClassMatch.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RequiredSpecialtyId { get; set; }
        public Specialty RequiredSpecialty { get; set; }
    }
}
