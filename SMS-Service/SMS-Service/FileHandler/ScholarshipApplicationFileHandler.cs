using SMS_Service.Model;
using SMS_Service.Serialization;
using System.Collections.Generic;
using System.Linq;

namespace SMS_Service.FileHandler
{
    public class ScholarshipApplicationFileHandler
    {
        private readonly Serializer<ScholarshipApplication> _serializer;

        private const string FilePath = "/Data/applications.csv";

        private List<ScholarshipApplication> _applications;

        public ScholarshipApplicationFileHandler()
        {
            _serializer = new Serializer<ScholarshipApplication>();
            _applications = _serializer.FromCSV(FilePath);
        }

        public ScholarshipApplication GetById(int id)
        {
            _applications = _serializer.FromCSV(FilePath);
            return _applications.FirstOrDefault(s => s.ID == id);
        }

        public List<ScholarshipApplication> Load()
        {
            return _serializer.FromCSV(FilePath);
        }

        public void Save(List<ScholarshipApplication> applications)
        {
            _serializer.ToCSV(FilePath, applications);
        }
    }
}