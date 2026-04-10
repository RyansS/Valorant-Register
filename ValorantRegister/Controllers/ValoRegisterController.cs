using Microsoft.AspNetCore.Mvc;
using ValorantRegister.Data;
using ValorantRegister.Model;

namespace ValorantRegister.Controllers
{
    [Route("api/[controller]")]
    public class ValoRegisterController : ControllerBase
    {
        private ValoContext valoContext;



        [HttpGet]

        public IActionResult GetAllUsers()
        {
            return Ok(valoContext.Users);
        }


    }
}
