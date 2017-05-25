using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebAPI_database.Models
{
    public class StudentDbContext: DbContext
    {
        public StudentDbContext()
            :base("DefaultConnection")
        {

        }

        public DbSet<Student> dbStudent { get; set; }
    }
}