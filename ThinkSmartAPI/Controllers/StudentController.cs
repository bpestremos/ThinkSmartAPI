using Microsoft.AspNetCore.DataProtection.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ThinkSmartAPI.Interfaces;
using ThinkSmartAPI.Models;

namespace ThinkSmartAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : Controller
    {
        private readonly StudentInterface _studentInterface;

        public StudentController(StudentInterface studentInterface)
        {
            _studentInterface = studentInterface;
        }

        [HttpGet]
        [Route("GetStudents")]
        // GET: StudentController/Details/5
        public ActionResult GetStudents()
        {
            return Ok(_studentInterface.GetStudents());
        }



        [HttpPost]
        [Route("InsertStudents")]
        // GET: StudentController/Details/5
        public ActionResult InsertStudent([FromBody] Students stud)
        {

            return Ok(_studentInterface.GetStudents());
        }
    }
}
