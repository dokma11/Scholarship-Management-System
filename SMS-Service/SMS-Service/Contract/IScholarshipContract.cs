using SMS_Service.Model;
using System.Collections.Generic;
using System.ServiceModel;

namespace SMS_Service.Contract
{
    [ServiceContract]   
    public interface IScholarshipContract
    {
        [OperationContract]
        void Create(Scholarship scholarship);

        [OperationContract]
        void Update(Scholarship scholarship);

        [OperationContract]
        void Delete(int id);

        [OperationContract]
        List<Scholarship> GetAll();

        [OperationContract]
        Scholarship GetById(int id);
    }
}