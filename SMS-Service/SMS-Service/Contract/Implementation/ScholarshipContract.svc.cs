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
            Console.WriteLine("Scholarship contract create");
            scholarship.ScholarshipApplications = new List<ScholarshipApplication>();
            _scholarshipService.Create(scholarship);
        }

        public void Update(Scholarship scholarship)
        {
            Console.WriteLine("Scholarship contract update");
            _scholarshipService.Update(scholarship);
        }

        public void Delete(int id)
        {
            Console.WriteLine("Scholarship contract delete, ID: " + id);
            _scholarshipService.Delete(id);
        }

        public Scholarship GetById(int id)
        {
            Console.WriteLine("Scholarship contract get by id, ID: " + id);
            return _scholarshipService.GetById(id);
        }

        public List<Scholarship> GetAll()
        {
            Console.WriteLine("Scholarship contract get all");
            return _scholarshipService.GetAll();
        }
    }
}
