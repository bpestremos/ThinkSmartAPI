﻿using ThinkSmartAPI.Interfaces;
using ThinkSmartAPI.Models;

namespace ThinkSmartAPI.Services
{
    public class StudentServices : StudentInterface
    {
        private readonly AppDBContext _context;
        public StudentServices(AppDBContext context)
        {
            _context = context;
        }


        public List<Students> GetStudents()
        {
            return _context.Students.ToList();
        }
    }
}
