using SMS_Service.Model;
using System.Collections.Generic;
using System.ServiceModel;

namespace SMS_Service.Contract
{
    [ServiceContract]
    public interface IStudentContract
    {
        [OperationContract]
        void Create(Student student);
        
        [OperationContract]
        void Update(Student student);
        
        [OperationContract]
        void Delete(int id);

        [OperationContract]
        List<Student> GetAll();

        [OperationContract]
        Student GetById(int id);
    }
}