using SMS_Service.Model;
using SMS_Service.Serialization;
using System.Collections.Generic;
using System.Linq;

namespace SMS_Service.FileHandler
{
    public class ScholarshipFileHandler
    {
        private readonly Serializer<Scholarship> _serializer;

        private const string FilePath = "../../../Data/scholarships.csv";

        private List<Scholarship> _scholarships;

        public ScholarshipFileHandler()
        {
            _serializer = new Serializer<Scholarship>();
            _scholarships = _serializer.FromCSV(FilePath);
        }

        public Scholarship GetById(int id)
        {
            _scholarships = _serializer.FromCSV(FilePath);
            return _scholarships.FirstOrDefault(s => s.ID == id);
        }

        public List<Scholarship> Load()
        {
            return _serializer.FromCSV(FilePath);
        }

        public void Save(List<Scholarship> scholarships)
        {
            _serializer.ToCSV(FilePath, scholarships);
        }
    }
}