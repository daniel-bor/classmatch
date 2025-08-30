namespace ClassMatch.Models
{
    public class Section
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public int? TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public int? ClassroomId { get; set; }
        public Classroom Classroom { get; set; }
        public DayOfWeek Day { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public List<Student> Students { get; set; }
    }
}
