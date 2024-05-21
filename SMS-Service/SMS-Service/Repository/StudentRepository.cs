﻿using SMS_Service.FileHandler;
using SMS_Service.Model;
using SMS_Service.Repository.Implementation;
using System.Collections.Generic;
using System.Linq;

namespace SMS_Service.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly StudentFileHandler _fileHandler;
        private List<Student> _students;

        public StudentRepository()
        {
            _fileHandler = new StudentFileHandler();
            _students = _fileHandler.Load();
        }

        public int NextId()
        {
            return _students.Count == 0 ? 1 : _students.Max(t => t.ID) + 1;
        }

        public void Create(Student student)
        {
            student.ID = NextId();
            _students.Add(student);
            _fileHandler.Save(_students);
        }

        public void Update(Student student) 
        {
            int index = _students.FindIndex(p => p.ID == student.ID);
            if (index != -1)
            {
                _students[index] = student;
            }

            _fileHandler.Save(_students);
        }

        public void Delete(int id) 
        {
            int index = _students.FindIndex(p => p.ID == id);
            if (index != -1)
            {
                _students[index].IsDeleted = true;
            }

            _fileHandler.Save(_students);
        }

        public List<Student> GetAll()
        {
            return _students;
        }

        public Student GetById(int id)
        {
            return _fileHandler.GetById(id);
        }

    }
}