using SMS_Service.FileHandler;
using SMS_Service.Model;
using SMS_Service.Repository.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SMS_Service.Repository
{
    public class ScholarshipRepository: IScholarshipRepository
    {
        private readonly ScholarshipFileHandler _fileHandler;
        private List<Scholarship> _scholarships;

        public ScholarshipRepository()
        {
            _fileHandler = new ScholarshipFileHandler();
            _scholarships = _fileHandler.Load();
        }

        public int NextId()
        {
            return _scholarships.Count == 0 ? 1 : _scholarships.Max(t => t.ID) + 1;
        }

        public void Create(Scholarship scholarship)
        {
            scholarship.ID = NextId();
            _scholarships.Add(scholarship);
            _fileHandler.Save(_scholarships);
            Console.WriteLine("Scholarship successfully created");
        }

        public void Update(Scholarship scholarship)
        {
            int index = _scholarships.FindIndex(p => p.ID == scholarship.ID);
            if (index != -1)
            {
                _scholarships[index] = scholarship;
            }

            _fileHandler.Save(_scholarships);
            Console.WriteLine("Scholarship successfully updated");
        }

        public void Delete(int id)
        {
            int index = _scholarships.FindIndex(p => p.ID == id);
            if (index != -1)
            {
                _scholarships[index].IsDeleted = true;
            }

            _fileHandler.Save(_scholarships);
            Console.WriteLine("Scholarship successfully deleted");
        }

        public List<Scholarship> GetAll()
        {
            return _scholarships.Where(s => s.IsDeleted == false).ToList();
        }

        public Scholarship GetById(int id)
        {
            return _fileHandler.GetById(id);
        }
    }
}