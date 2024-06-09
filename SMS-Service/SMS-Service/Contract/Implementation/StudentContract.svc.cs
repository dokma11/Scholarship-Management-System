using SMS_Service.Model;
using SMS_Service.Service;
using System;
using System.Collections.Generic;

namespace SMS_Service.Contract
{
    public class StudentContract : IStudentContract
    {
        private readonly StudentService _studentService;

        public StudentContract()
        {
            _studentService = new StudentService();
        }

        public void Create(Student student)
        {
            Console.WriteLine("Student contract create");
            student.ScholarshipApplications = new List<ScholarshipApplication>();
            if (student.FirstName.Length < 1 || student.LastName.Length < 1 || student.Email.Length < 1 || student.DateOfBirth.Length < 1 ||
                student.GPA < 5.00 || student.IsDeleted == true)
            {
                Console.WriteLine("Student information not valid, student won't be created");
            }
            else
            {
                _studentService.Create(student);
            }
        }

        public void Update(Student student)
        {
            Console.WriteLine("Student contract update");
            if (student.FirstName.Length < 1 || student.LastName.Length < 1 || student.Email.Length < 1 || student.DateOfBirth.Length < 1 ||
                            student.GPA < 5.00 || student.IsDeleted == true)
            {
                Console.WriteLine("Student information not valid, student won't be updated");
            }
            else
            {
                _studentService.Update(student);
            }
        }

        public void Delete(int id)
        {
            Console.WriteLine("Student contract delete, id: " + id);
            _studentService.Delete(id);
        }

        public Student GetById(int id)
        {
            Console.WriteLine("Student contract get by id, id: " + id);
            return _studentService.GetById(id);
        }

        public List<Student> GetAll()
        {
            Console.WriteLine("Student contract get all");
            return _studentService.GetAll();
        }
    }
}
