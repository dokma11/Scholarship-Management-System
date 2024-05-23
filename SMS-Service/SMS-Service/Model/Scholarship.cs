using SMS_Service.Serialization;
using System;
using System.Collections.Generic;

namespace SMS_Service.Model
{
    public class Scholarship: ISerializable
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Amount { get; set; }
        public DateTime Deadline { get; set; }
        public double? GPARequirement { get; set; }
        public int? MinAge { get; set; }
        public int? MaxAge { get; set; }
        public StudentEducation Education { get; set; }
        public int? StudentLimit { get; set; }
        public bool IsDeleted { get; set; }
        public List<ScholarshipApplication> ScholarshipApplications { get; set; }

        public Scholarship()
        {
            ScholarshipApplications = new List<ScholarshipApplication>();
        }

        public Scholarship(int iD, string name, string description, double amount, DateTime deadline, double gPARequirement, int minAge, int maxAge, StudentEducation education, int studentLimit, bool isDeleted)
        {
            ID = iD;
            Name = name;
            Description = description;
            Amount = amount;
            Deadline = deadline;
            GPARequirement = gPARequirement;
            MinAge = minAge;
            MaxAge = maxAge;
            Education = education;
            StudentLimit = studentLimit;
            IsDeleted = isDeleted;
        }

        public string[] ToCSV()
        {
            string[] csvValues =
            {
                ID.ToString(),
                Name,
                Description,
                Amount.ToString(),
                Deadline.ToString(),
                GPARequirement.ToString(),
                MinAge.ToString(),
                MaxAge.ToString(), 
                Education.ToString(),
                StudentLimit.ToString(),
                IsDeleted.ToString(),
            };
            return csvValues;
        }

        public void FromCSV(string[] values)
        {
            ID = Convert.ToInt32(values[0]);
            Name = values[1];
            Description = values[2];
            Amount = Convert.ToDouble(values[3]);
            Deadline = Convert.ToDateTime(values[4]);
            GPARequirement = Convert.ToDouble(values[5]);
            MinAge = Convert.ToInt32(values[6]);
            MaxAge = Convert.ToInt32(values[7]);
            Education = (StudentEducation)Enum.Parse(typeof(StudentEducation), values[8]);
            StudentLimit = Convert.ToInt32(values[9]);
            IsDeleted = Convert.ToBoolean(values[10]);
        }
    }
}