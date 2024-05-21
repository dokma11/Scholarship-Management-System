using SMS_Service.Model;
using SMS_Service.Serialization;
using System.Collections.Generic;
using System.Linq;

namespace SMS_Service.FileHandler
{
    public class StudentFileHandler
    {
        private readonly Serializer<Student> _serializer;

        private const string FilePath = "../../../Data/students.csv";

        private List<Student> _students;

        public StudentFileHandler()
        {
            _serializer = new Serializer<Student>();
            _students = _serializer.FromCSV(FilePath);
        }

        public Student GetById(int id)
        {
            _students = _serializer.FromCSV(FilePath);
            return _students.FirstOrDefault(s => s.ID == id);
        }

        public List<Student> Load()
        {
            return _serializer.FromCSV(FilePath);
        }

        public void Save(List<Student> students)
        {
            _serializer.ToCSV(FilePath, students);
        }
    }
}