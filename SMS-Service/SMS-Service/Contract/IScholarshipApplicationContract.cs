using SMS_Service.Model;
using System.Collections.Generic;
using System.ServiceModel;

namespace SMS_Service.Contract
{
    [ServiceContract]
    public interface IScholarshipApplicationContract
    {
        [OperationContract]
        void ApplyForScholarship(int studentID, int scholarshipID);

        [OperationContract]
        string CheckApplicationStatus(int applicationID);

        [OperationContract]
        List<ScholarshipApplication> GetPending();

        [OperationContract]
        void AcceptScholarshipApplication(int applicationID);

        [OperationContract]
        void RejectScholarshipApplication(int applicationID);
    }
}