using SMS_Service.Model;
using SMS_Service.Repository;
using SMS_Service.Repository.Implementation;
using System.Collections.Generic;

namespace SMS_Service.Service
{
    public class ScholarshipApplicationService
    {
        private readonly IScholarshipApplicationRepository _repository;

        public ScholarshipApplicationService()
        {
            _repository = new ScholarshipApplicationRepository();
        }

        public void ApplyForScholarship(int studentID, int scholarshipID)
        {
            _repository.Create(studentID, scholarshipID);
        }

        public string CheckApplicationStatus(int applicationID)
        {
            return _repository.CheckApplicationStatus(applicationID).ToString();
        }

        public List<ScholarshipApplication> GetPending()
        {
            return _repository.GetPending();
        }

        public void AcceptScholarshipApplication(int applicationID)
        {
            _repository.HandleScholarship(applicationID, true);
        }

        public void RejectScholarshipApplication(int applicationID)
        {
            _repository.HandleScholarship(applicationID, false);
        }
    }
}