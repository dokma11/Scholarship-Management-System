using SMS_Service.Model;
using System.Collections.Generic;

namespace SMS_Service.Repository.Implementation
{
    public interface IScholarshipApplicationRepository
    {
        int NextId();
        void Create(int studentID, int scholarshipID);
        void HandleScholarship(int applicationId, bool approved);
        ScholarshipApplicationStatus CheckApplicationStatus(int applicationID);
        List<ScholarshipApplication> GetPending();
    }
}