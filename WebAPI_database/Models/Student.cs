using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAPI_database.Models
{
    public class Student
    {
        [Key]
        public int studentID { get; set; }

        public string firstName { get; set; }
        public string middleName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
    }
}