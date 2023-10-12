using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using Web_optional.Models;

namespace Web_optional.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        public static List<Class> students = new List<Class>
        {
            new Class { Id = 1, Name = "Ana", Age = 21 },
            new Class { Id = 2, Name = "Maria", Age = 19 },
            new Class { Id = 3, Name = "Vlad", Age = 22 },
            new Class { Id = 4, Name = "Florin", Age = 25 },
            new Class { Id = 5, Name = "Marian", Age = 20 }

        };

        //endpoint
        //Get
        /*[HttpGet]

        public List<Class> Get()
        {
            return students;
        }*/

        // Create

        [HttpPost]

        public List<Class> Add(Class student) 
        {
            students.Add(student);
            return students;
        }

       /* [HttpDelete]
        public List<Class> Delete(Class student)
        {
            var studentIndex = students.FindIndex( x => x.Id == student.Id);
            students.RemoveAt(studentIndex);
            return students;
        }
*/
        /*
        faceti un alt endpoint de delete by id (int), si un endpoint get care
        sa se numeasca "getAllOrdered" unde folositi 
        .OrderBy(s => s.Age).ToList(); (ordonati dupa ce vreti voi) 
        */

        [HttpDelete]
        public List<Class> Delete(int id) 
        {
            var studentIndex = students.FindIndex(x => x.Id == id);
            students.RemoveAt(studentIndex);
            return students;
        }

        [HttpGet]
        public List<Class> getAllOrdered()
        {
            students = students.OrderBy(s => s.Age).ToList();
            return students;
        }

    }
}
