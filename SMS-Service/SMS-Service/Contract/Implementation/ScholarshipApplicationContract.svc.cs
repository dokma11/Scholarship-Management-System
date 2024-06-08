using SMS_Service.Model;
using SMS_Service.Service;
using System.Collections.Generic;

namespace SMS_Service.Contract
{
    public class ScholarshipApplicationContract : IScholarshipApplicationContract
    {
        private readonly ScholarshipApplicationService _service;

        public ScholarshipApplicationContract() 
        { 
            _service = new ScholarshipApplicationService();
        }

        public void ApplyForScholarship(int studentID, int scholarshipID)
        {
            _service.ApplyForScholarship(studentID, scholarshipID);
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
