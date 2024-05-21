using SMS_Service.Model;
using System.Collections.Generic;

namespace SMS_Service.Repository.Implementation
{
    public interface IStudentRepository
    {
        int NextId();
        void Create(Student student);
        void Update(Student student);
        void Delete(int id);
        List<Student> GetAll();
        Student GetById(int id);
    }
}