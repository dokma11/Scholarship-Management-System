using SMS_Service.Model;
using System.Collections.Generic;

namespace SMS_Service.Repository.Implementation
{
    public interface IScholarshipRepository
    {
        int NextId();
        void Create(Scholarship scholarship);
        void Update(Scholarship scholarship);
        void Delete(int id);
        List<Scholarship> GetAll();
        Scholarship GetById(int id);
    }
}