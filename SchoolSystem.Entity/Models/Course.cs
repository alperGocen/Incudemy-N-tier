using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Entity.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string courseName { get; set; }
        public int Credit { get; set; }


        //Mapping
        public List<Student> Students { get; set; }
        public Department Department { get; set; }
    }
}
