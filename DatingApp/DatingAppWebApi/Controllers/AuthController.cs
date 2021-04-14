using DatingAppWebApi.DatingAppDto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingAppWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        public AuthController()
        {

        }

        [HttpPost("register")]
        public ActionResult Register([FromBody]RegisterUserDto usrDto)
        {
            return Ok();
        }
    }
}
