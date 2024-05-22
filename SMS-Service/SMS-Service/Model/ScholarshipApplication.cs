using SMS_Service.Serialization;
using System;

namespace SMS_Service.Model
{
    public class ScholarshipApplication: ISerializable
    {
        public int ID { get; set; }
        public ScholarshipApplicationStatus Status { get; set; }
        public DateTime SubmissionDate { get; set; }
        public DateTime ApprovalDate { get; set; }

        public ScholarshipApplication() { }

        public ScholarshipApplication(int iD, ScholarshipApplicationStatus status, DateTime submissionDate, DateTime approvalDate)
        {
            ID = iD;
            Status = status;
            SubmissionDate = submissionDate;
            ApprovalDate = approvalDate;
        }

        public string[] ToCSV()
        {
            string[] csvValues =
            {
                ID.ToString(),
                Status.ToString(),
                SubmissionDate.ToString(),
                ApprovalDate.ToString(),
            };
            return csvValues;
        }

        public void FromCSV(string[] values)
        {
            ID = Convert.ToInt32(values[0]);
            Status = (ScholarshipApplicationStatus)Enum.Parse(typeof(ScholarshipApplicationStatus), values[1]);
            SubmissionDate = Convert.ToDateTime(values[2]);
            ApprovalDate = Convert.ToDateTime(values[3]);
        }
    }

    public enum ScholarshipApplicationStatus
    {
        Pending,
        Approved,
        Rejected
    }
}