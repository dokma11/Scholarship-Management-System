using SMS_Service.FileHandler;
using SMS_Service.Model;
using SMS_Service.Repository.Implementation;
using System.Collections.Generic;
using System.Linq;

namespace SMS_Service.Repository
{
    public class ScholarshipApplicationRepository : IScholarshipApplicationRepository
    {
        private readonly ScholarshipApplicationFileHandler _fileHandler;
        private List<ScholarshipApplication> _applications;

        public ScholarshipApplicationRepository()
        {
            _fileHandler = new ScholarshipApplicationFileHandler();
            _applications = _fileHandler.Load();
        }

        public int NextId()
        {
            return _applications.Count == 0 ? 1 : _applications.Max(t => t.ID) + 1;
        }

        public void Create(int studentID, int scholarshipID)
        {
            ScholarshipApplication application = new ScholarshipApplication(NextId(), ScholarshipApplicationStatus.Pending,
                System.DateTime.Now, studentID, scholarshipID);

            _applications.Add(application);
            _fileHandler.Save(_applications);
        }

        public void HandleScholarship(int applicationId, bool approved)
        {
            int index = _applications.FindIndex(a => a.ID == applicationId);
            if (index != -1)
            {
                if (approved)
                {
                    _applications[index].Status = ScholarshipApplicationStatus.Approved;
                }
                else
                {
                    _applications[index].Status = ScholarshipApplicationStatus.Rejected;
                }
            }

            _fileHandler.Save(_applications);
        }

        public ScholarshipApplicationStatus CheckApplicationStatus(int applicationID)
        {
            return _fileHandler.GetById(applicationID).Status;
        }

        public List<ScholarshipApplication> GetPending()
        {
            return _applications.Where(a => a.Status == ScholarshipApplicationStatus.Pending).ToList();
        }
    }
}