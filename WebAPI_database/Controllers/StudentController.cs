using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI_database.Models;

namespace WebAPI_database.Controllers
{
    public class StudentController : ApiController
    {
        StudentDbContext data = new StudentDbContext();
        
        public IEnumerable<Student> Get()
        {
            return data.dbStudent.ToList();
        }

        public Student Get(int id)
        {
            return data.dbStudent.Find(id);
        }

        public void Post([FromBody] Student student)
        {
            data.dbStudent.Add(student);
            data.SaveChanges();
        }

        public void Put(int id, [FromBody] Student student)
        {
            Student stud = data.dbStudent.Find(id);
            stud.studentID = student.studentID;
            stud.firstName = student.firstName;
            stud.middleName = student.middleName;
            stud.lastName = student.lastName;
            stud.age = student.age;
            data.SaveChanges();
        }

        public void Delete(int id)
        { 
            Student stud = data.dbStudent.Find(id);
            data.dbStudent.Remove(stud);
            data.SaveChanges();
        }
    }
}
