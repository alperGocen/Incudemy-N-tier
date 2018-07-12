using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Entity.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string departmentName { get; set; }
        public string Location { get; set; }

        //Mapping
        public List<Student> Students { get; set; }
        public List<Course> Courses { get; set; }
    }
}
