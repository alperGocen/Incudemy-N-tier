namespace SchoolSystem.Entity
{
    using SchoolSystem.Entity.Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class SchoolSystemDbContext : DbContext
    {
       
        public SchoolSystemDbContext()
            : base("name=SchoolSystemDbContext")
        {
        }

        

         public virtual DbSet<Student> Students { get; set; }
         public virtual DbSet<Course> Courses { get; set; }
         public virtual DbSet<Department> Departments { get; set; }

    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}