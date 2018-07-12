using SchoolSystem.Entity;
using SchoolSystem.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.DAL.Repositories
{
    public static class StudentRepository
    {
        public static List<Student> GetAllStudents()
        {
            using (SchoolSystemDbContext db = new SchoolSystemDbContext())
            {
                var students = db.Students.ToList();
                return students;
            }
        }


        public static void AddStudent(Student student)
        {
            using (SchoolSystemDbContext db = new SchoolSystemDbContext())
            {
                db.Students.Add(student);
                db.SaveChanges();
            }
        }

        public static void DeleteStudent(int id)
        {
            using (SchoolSystemDbContext db = new SchoolSystemDbContext())
            {
                var student = db.Students.FirstOrDefault(s => s.Id == id);
                if (student != null)
                {
                    db.Students.Remove(student);
                    db.SaveChanges();
                }

            }
        }
    }
}
