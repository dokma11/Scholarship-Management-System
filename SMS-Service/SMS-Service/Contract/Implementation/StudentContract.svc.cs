using SMS_Service.Contract;
using SMS_Service.Model;
using SMS_Service.Service;
using System.Collections.Generic;

namespace SMS_Service
{
    public class StudentContract : IStudentContract
    {
        private readonly StudentService _studentService;

        public StudentContract() { }

        public void Create(Student student)
        {
            _studentService.Create(student);
        }

        public void Update(Student student)
        {
            _studentService.Update(student);
        }

        public void Delete(int id)
        {
            _studentService.Delete(id);
        }

        public Student GetById(int id)
        {
            return _studentService.GetById(id);
        }

        public List<Student> GetAll()
        {
            return _studentService.GetAll();
        }
    }
}
