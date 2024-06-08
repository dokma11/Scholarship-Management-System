using SMS_Service.Model;
using SMS_Service.Service;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SMS_Service.Contract
{
    public class StudentContract : IStudentContract
    {
        private readonly StudentService _studentService;

        public StudentContract() 
        {
            _studentService = new StudentService();
        }

        public async Task Create(Student student)
        {
            student.ScholarshipApplications = new List<ScholarshipApplication>();
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
