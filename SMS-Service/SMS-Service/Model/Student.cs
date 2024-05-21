using SMS_Service.Serialization;
using System;

namespace SMS_Service.Model
{
    public class Student : ISerializable
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string DateOfBirth { get; set; }
        public StudentEducation Education { get; set; }
        public double GPA { get; set; }
        public bool IsDeleted { get; set; }

        public Student() { }

        public Student(int iD, string firstName, string lastName, string email, string dateOfBirth, StudentEducation education, double gPA, bool isDeleted)
        {
            ID = iD;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            DateOfBirth = dateOfBirth;
            Education = education;
            GPA = gPA;
            IsDeleted = isDeleted;
        }

        public string[] ToCSV()
        {
            string[] csvValues =
            {
                ID.ToString(),
                FirstName,
                LastName,
                Email,
                DateOfBirth,
                Education.ToString(),
                GPA.ToString(),
                IsDeleted.ToString(),
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
            Education = (StudentEducation)Enum.Parse(typeof(StudentEducation), values[5]);
            GPA  = Convert.ToDouble(values[6]);
            IsDeleted = Convert.ToBoolean(values[7]);
        }
    }

    public enum StudentEducation
    {
        HighSchool,
        University
    }
}
