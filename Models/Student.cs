namespace ClassMatch.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string UniversityId { get; set; } // Carné
        public string Name { get; set; }
        public Gender Gender { get; set; }
    }

    public class Gender
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
