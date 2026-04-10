using Microsoft.AspNetCore.Mvc;
using ValorantRegister.Data;
using ValorantRegister.Model;

namespace ValorantRegister.Controllers
{
    [Route("api/[controller]")]
    public class ValoRegisterController : ControllerBase
    {
        private ValoContext valoContext;

        [HttpPost]
        public IActionResult PostRegisterUser([FromBody] ValoRegister user)
        {
            valoContext.Users.Add(user);

            return CreatedAtAction(nameof(GetUserById), new {id = user.Id}, user);
        }

        [HttpGet]

        public IActionResult GetAllUsers()
        {
            return Ok(valoContext.Users);
        }

        [HttpGet("{id}")]
        public IActionResult GetUserById (int id)
        {
            var user = valoContext.Users.FirstOrDefault(user => user.Id == id);

            if (user == null) return NotFound();

            return Ok(user);
        }
    }
}
