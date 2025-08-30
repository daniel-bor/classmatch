using System.Collections.Generic;
using ClassMatch.Models;

namespace ClassMatch.Services
{
    public class TeacherService()
    {
        private readonly List<Teacher> _teachers = new List<Teacher>();

        public IEnumerable<Teacher> GetAll()
        {
            return _teachers;
        }

        public Teacher? GetById(int id)
        {
            return _teachers.Find(t => t.Id == id);
        }

        public void Add(Teacher teacher)
        {
            _teachers.Add(teacher);
        }

        public void AssignSpecialty(int teacherId, string specialty)
        {
            var teacher = GetById(teacherId);
            if (teacher != null)
            {
                teacher.Specialties.Add(new Specialty { Name = specialty });
            }
        }

        public void Remove(int id)
        {
            var teacher = GetById(id);
            if (teacher != null)
            {
                _teachers.Remove(teacher);
            }
        }
    }
}
