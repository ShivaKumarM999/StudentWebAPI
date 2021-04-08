using StudentWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace StudentWebAPI.Controllers
{
    [RoutePrefix("api/Students")]
    public class StudentsController : ApiController
    {
        static List<Student> students = new List<Student>()
        {
            new Student(){Id=1, Name="Shiva"},
            new Student(){Id=2, Name="Rama"},
            new Student(){Id=3, Name="Krushna"},
            new Student(){Id=9999, Name="Govinda"}
        };

        [Route("")]
        public IEnumerable<Student> Get()
        {
            return students;
        }

        [Route("{id:int:min(1):max(10000)}")]
        public Student Get(int id)
        {
            return students.FirstOrDefault(a => a.Id == id);
        }

        [Route("{name:alpha}")]
        public Student Get(string name)
        {
            return students.FirstOrDefault(a => a.Name == name);
        }


        [Route("Courses/{id}")]
        public IEnumerable<string> GetStudentCourses(int Id)
        {
            if(Id==1)
            {
                return new List<string>() { "C#", "ASP.NET", "SQL" };
            }
            else if (Id == 2)
            {
                return new List<string>() { "WEBAPI", "Core", "Mongo" };
            }
            else
            {
                return new List<string>() { "Bootstrap", "jQuery", "Angularjs" };
            }
        }

        static List<Teacher> teachers = new List<Teacher>()
        {
            new Teacher(){Id=1, Name="Shiva Ram"},
            new Teacher(){Id=2, Name="Rama Krushna"},
            new Teacher(){Id=3, Name="Krushna Govida"}
        };

        [Route("~/api/Teachers/")]
        public IEnumerable<Teacher> GetTeacher()
        {
            return teachers;
        }

    }
}
