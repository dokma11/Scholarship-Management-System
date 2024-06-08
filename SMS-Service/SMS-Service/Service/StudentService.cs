using SMS_Service.Model;
using SMS_Service.Repository;
using SMS_Service.Repository.Implementation;
using System.Collections.Generic;

namespace SMS_Service.Service
{
    public class StudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService()
        {
            _studentRepository = new StudentRepository();
        }

        public void Create(Student student)
        {
            _studentRepository.Create(student);
        }

        public void Update(Student student)
        {
            _studentRepository.Update(student);
        }

        public void Delete(int id)
        {
            _studentRepository.Delete(id);
        }

        public List<Student> GetAll()
        {
            return _studentRepository.GetAll();
        }

        public Student GetById(int id)
        {
            return _studentRepository.GetById(id);
        }
    }
}