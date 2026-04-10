using Microsoft.AspNetCore.Mvc;
using ValorantRegister.Data;
using ValorantRegister.Model;

namespace ValorantRegister.Controllers
{
    [Route("api/[controller]")]

    

    public class ValoRegisterController : ControllerBase
    {
        private ValoContext _valoContext;

        public ValoRegisterController (ValoContext valoContext)
        {
            _valoContext = valoContext;
        }

        [HttpPost]
        public IActionResult PostRegisterUser([FromBody] ValoRegister user)
        {
            _valoContext.Users.Add(user);
            _valoContext.SaveChanges();

            return CreatedAtAction(nameof(GetUserById), new {id = user.Id}, user);
        }

        [HttpGet]

        public IActionResult GetAllUsers()
        {
            return Ok(_valoContext.Users);
        }

        [HttpGet("{id}")]
        public IActionResult GetUserById (int id)
        {
            var user = _valoContext.Users.FirstOrDefault(user => user.Id == id);

            if (user == null) return NotFound();

            return Ok(user);
        }
    }
}
