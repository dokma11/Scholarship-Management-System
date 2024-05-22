using SMS_Service.Model;
using SMS_Service.Repository.Implementation;
using System.Collections.Generic;

namespace SMS_Service.Service
{
    public class ScholarshipService
    {
        private readonly IScholarshipRepository _scholarshipRepository;

        public ScholarshipService() { }

        public void Create(Scholarship scholarship)
        {
            _scholarshipRepository.Create(scholarship);
        }

        public void Update(Scholarship scholarship)
        {
            _scholarshipRepository.Update(scholarship);
        }

        public void Delete(int id)
        {
            _scholarshipRepository.Delete(id);
        }

        public List<Scholarship> GetAll()
        {
            return _scholarshipRepository.GetAll();
        }

        public Scholarship GetById(int id)
        {
            return _scholarshipRepository.GetById(id);
        }
    }
}