using Microsoft.AspNetCore.DataProtection.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ThinkSmartAPI.Interfaces;

namespace ThinkSmartAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly UsersInterface _usersInterface;

        public UserController(UsersInterface usersInterface)
        {
            _usersInterface = usersInterface;
        }

        [Route("GetUsers")]
        [HttpGet]
        // GET: StudentController/Details/5
        public ActionResult GetUsers()
        {
            return Ok(_usersInterface.GetUsers());
        }
    }
}
