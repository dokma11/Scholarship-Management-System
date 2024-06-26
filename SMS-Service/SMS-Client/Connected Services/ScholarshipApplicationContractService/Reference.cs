﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ScholarshipApplicationContractService
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ScholarshipApplication", Namespace="http://schemas.datacontract.org/2004/07/SMS_Service.Model")]
    public partial class ScholarshipApplication : object
    {
        
        private System.Nullable<System.DateTime> ApprovalDateField;
        
        private int IDField;
        
        private int ScholarshipIdField;
        
        private ScholarshipApplicationContractService.ScholarshipApplicationStatus StatusField;
        
        private int StudentIdField;
        
        private System.DateTime SubmissionDateField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> ApprovalDate
        {
            get
            {
                return this.ApprovalDateField;
            }
            set
            {
                this.ApprovalDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID
        {
            get
            {
                return this.IDField;
            }
            set
            {
                this.IDField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ScholarshipId
        {
            get
            {
                return this.ScholarshipIdField;
            }
            set
            {
                this.ScholarshipIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ScholarshipApplicationContractService.ScholarshipApplicationStatus Status
        {
            get
            {
                return this.StatusField;
            }
            set
            {
                this.StatusField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int StudentId
        {
            get
            {
                return this.StudentIdField;
            }
            set
            {
                this.StudentIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime SubmissionDate
        {
            get
            {
                return this.SubmissionDateField;
            }
            set
            {
                this.SubmissionDateField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ScholarshipApplicationStatus", Namespace="http://schemas.datacontract.org/2004/07/SMS_Service.Model")]
    public enum ScholarshipApplicationStatus : int
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Pending = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Approved = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Rejected = 2,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ScholarshipApplicationContractService.IScholarshipApplicationContract")]
    public interface IScholarshipApplicationContract
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IScholarshipApplicationContract/ApplyForScholarship", ReplyAction="http://tempuri.org/IScholarshipApplicationContract/ApplyForScholarshipResponse")]
        System.Threading.Tasks.Task ApplyForScholarshipAsync(int studentID, int scholarshipID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IScholarshipApplicationContract/CheckApplicationStatus", ReplyAction="http://tempuri.org/IScholarshipApplicationContract/CheckApplicationStatusResponse" +
            "")]
        System.Threading.Tasks.Task<string> CheckApplicationStatusAsync(int applicationID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IScholarshipApplicationContract/GetPending", ReplyAction="http://tempuri.org/IScholarshipApplicationContract/GetPendingResponse")]
        System.Threading.Tasks.Task<ScholarshipApplicationContractService.ScholarshipApplication[]> GetPendingAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IScholarshipApplicationContract/AcceptScholarshipApplication", ReplyAction="http://tempuri.org/IScholarshipApplicationContract/AcceptScholarshipApplicationRe" +
            "sponse")]
        System.Threading.Tasks.Task AcceptScholarshipApplicationAsync(int applicationID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IScholarshipApplicationContract/RejectScholarshipApplication", ReplyAction="http://tempuri.org/IScholarshipApplicationContract/RejectScholarshipApplicationRe" +
            "sponse")]
        System.Threading.Tasks.Task RejectScholarshipApplicationAsync(int applicationID);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    public interface IScholarshipApplicationContractChannel : ScholarshipApplicationContractService.IScholarshipApplicationContract, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    public partial class ScholarshipApplicationContractClient : System.ServiceModel.ClientBase<ScholarshipApplicationContractService.IScholarshipApplicationContract>, ScholarshipApplicationContractService.IScholarshipApplicationContract
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public ScholarshipApplicationContractClient() : 
                base(ScholarshipApplicationContractClient.GetDefaultBinding(), ScholarshipApplicationContractClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IScholarshipApplicationContract.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ScholarshipApplicationContractClient(EndpointConfiguration endpointConfiguration) : 
                base(ScholarshipApplicationContractClient.GetBindingForEndpoint(endpointConfiguration), ScholarshipApplicationContractClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ScholarshipApplicationContractClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(ScholarshipApplicationContractClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ScholarshipApplicationContractClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(ScholarshipApplicationContractClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ScholarshipApplicationContractClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task ApplyForScholarshipAsync(int studentID, int scholarshipID)
        {
            return base.Channel.ApplyForScholarshipAsync(studentID, scholarshipID);
        }
        
        public System.Threading.Tasks.Task<string> CheckApplicationStatusAsync(int applicationID)
        {
            return base.Channel.CheckApplicationStatusAsync(applicationID);
        }
        
        public System.Threading.Tasks.Task<ScholarshipApplicationContractService.ScholarshipApplication[]> GetPendingAsync()
        {
            return base.Channel.GetPendingAsync();
        }
        
        public System.Threading.Tasks.Task AcceptScholarshipApplicationAsync(int applicationID)
        {
            return base.Channel.AcceptScholarshipApplicationAsync(applicationID);
        }
        
        public System.Threading.Tasks.Task RejectScholarshipApplicationAsync(int applicationID)
        {
            return base.Channel.RejectScholarshipApplicationAsync(applicationID);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IScholarshipApplicationContract))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IScholarshipApplicationContract))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:54087/ScholarshipApplicationService");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return ScholarshipApplicationContractClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IScholarshipApplicationContract);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return ScholarshipApplicationContractClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IScholarshipApplicationContract);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IScholarshipApplicationContract,
        }
    }
}
