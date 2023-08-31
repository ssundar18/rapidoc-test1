using IGeekFan.AspNetCore.RapiDoc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;

namespace rapi_doc.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        /// <summary>
        /// Student List
        /// </summary>
        /// <returns>Student Name and Age information will be returned</returns>
        [RapiDocLabel("Provides the list of students.", RapiDocColor.RED)]
        [HttpGet(Name = "GetStudents")]
        public List<Student> GetStudent()
        {
            List<Student> list = new List<Student>();
            for (int i = 0; i < 5; i++)
            {
                Student s = new Student();
                s.Age = Random.Shared.Next(10, 15);
                s.Name = $"Student {Random.Shared.Next(-20, 55)}";
                list.Add(s);
            }
            return list;
        }

        ///// <summary>
        ///// Get the list of staffs from the school
        ///// </summary>
        ///// <returns></returns>
        //[RapiDocLabel("Provides the list of Staff.", RapiDocColor.RED)]
        //[HttpGet(Name = "GetStaff")]
        //public List<Student> GetStaff()
        //{
        //    List<Student> list = new List<Student>();
        //    for (int i = 0; i < 5; i++)
        //    {
        //        Student s = new Student();
        //        s.Age = Random.Shared.Next(30, 40);
        //        s.Name = $"Staff {Random.Shared.Next(-20, 55)}";
        //        list.Add(s);
        //    }
        //    return list;
        //}
    }
}
