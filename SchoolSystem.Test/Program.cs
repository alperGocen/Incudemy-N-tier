using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolSystem.DAL.Repositories;

namespace SchoolSystem.Test
{
    public class Program
    {
        static void Main(string[] args)
        {
            var students = StudentRepository.GetAllStudents();
            foreach (var student in students)
            {
                Console.WriteLine(student.Name);
            }
            Console.ReadKey();
        }
    }
}
