using MessengerApp.Models;
using MessengerApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace MessengerApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
         private IUserService _userService;

         public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<User> Add([FromBody] User user)
        {
            if(user == null)
            {
                return BadRequest();
            }
            _userService.Add(user); 
            return Ok();
        }
    }
}
