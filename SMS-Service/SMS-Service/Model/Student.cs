using SMS_Service.Serialization;
using System;

namespace SMS_Service.Model
{
    public class Student : ISerializable
    {
        private int ID { get; set; }
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private string Email { get; set; }
        private string DateOfBirth { get; set; }
        private Education education { get; set; }
        private double GPA { get; set; }

        public Student() { }

        public string[] ToCSV()
        {
            string[] csvValues =
            {
                ID.ToString(),
                FirstName,
                LastName,
                Email,
                DateOfBirth,
                education.ToString(),
                GPA.ToString()
            };
            return csvValues;
        }

        public void FromCSV(string[] values)
        {
            ID = Convert.ToInt32(values[0]);
            FirstName = values[1];
            LastName = values[2];
            Email = values[3];
            DateOfBirth = values[4];
            education = (Education)Enum.Parse(typeof(Education), values[5]);
            GPA  = Convert.ToDouble(values[6]);
        }
    }


    public enum Education
    {
        HighSchool,
        University
    }

}
