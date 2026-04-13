using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ValorantRegister.Data;
using ValorantRegister.DTOs;
using ValorantRegister.Model;

namespace ValorantRegister.Controllers
{
    [Route("api/[controller]")]

    

    public class ValoRegisterController : ControllerBase
    {
        private ValoContext _valoContext;
        private IMapper _mapper;

        public ValoRegisterController (ValoContext valoContext, IMapper mapper)
        {
            _valoContext = valoContext;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult PostRegisterUser([FromBody] ValoDto userDto)
        {
            ValoRegister user = _mapper.Map<ValoRegister>(userDto);

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
