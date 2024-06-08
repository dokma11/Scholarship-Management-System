using SMS_Service.Model;
using SMS_Service.Service;
using System;
using System.Collections.Generic;

namespace SMS_Service.Contract
{
    public class ScholarshipContract : IScholarshipContract
    {
        private readonly ScholarshipService _scholarshipService;

        public ScholarshipContract() 
        {
            _scholarshipService = new ScholarshipService();
        }

        public void Create(Scholarship scholarship)
        {
            _scholarshipService.Create(scholarship);
        }

        public void Update(Scholarship scholarship)
        {
            _scholarshipService.Update(scholarship);
        }

        public void Delete(int id)
        {
            _scholarshipService.Delete(id);
        }

        public Scholarship GetById(int id)
        {
            return _scholarshipService.GetById(id);
        }

        public List<Scholarship> GetAll()
        {
            return _scholarshipService.GetAll();
        }
    }
}
