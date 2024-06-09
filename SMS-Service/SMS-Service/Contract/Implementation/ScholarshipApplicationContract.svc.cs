using SMS_Service.Model;
using SMS_Service.Service;
using System;
using System.Collections.Generic;

namespace SMS_Service.Contract
{
    public class ScholarshipApplicationContract : IScholarshipApplicationContract
    {
        private readonly ScholarshipApplicationService _service;
        private readonly StudentService _studentService;
        private readonly ScholarshipService _scholarshipService;

        public ScholarshipApplicationContract()
        {
            _service = new ScholarshipApplicationService();
            _studentService = new StudentService();
            _scholarshipService = new ScholarshipService();
        }

        public void ApplyForScholarship(int studentID, int scholarshipID)
        {
            var student = _studentService.GetById(studentID);
            var scholarship = _scholarshipService.GetById(scholarshipID);

            var age = DateTime.Now.Year - DateTime.Parse(student.DateOfBirth).Year;

            if (student.GPA < scholarship.GPARequirement)
            {
                Console.WriteLine("Student has GPA lower than required");
                return;
            }
            else if (age < scholarship.MinAge || age > scholarship.MaxAge)
            {
                Console.WriteLine("Student does not meet age requirements");
                return;
            }
            else if (scholarship.Education == StudentEducation.University && student.Education == StudentEducation.HighSchool)
            {
                Console.WriteLine("Student does not meet education requirement");
                return;
            }
            else if (scholarship.Deadline < DateTime.Now)
            {
                Console.WriteLine("Scholarship deadline has expired");
                return;
            }
            else
            {
                _service.ApplyForScholarship(studentID, scholarshipID);
            }
        }

        public string CheckApplicationStatus(int applicationID)
        {
            return _service.CheckApplicationStatus(applicationID);
        }

        public List<ScholarshipApplication> GetPending()
        {
            return _service.GetPending();
        }

        public void AcceptScholarshipApplication(int applicationID)
        {
            _service.AcceptScholarshipApplication(applicationID);
        }

        public void RejectScholarshipApplication(int applicationID)
        {
            _service.RejectScholarshipApplication(applicationID);
        }
    }
}
