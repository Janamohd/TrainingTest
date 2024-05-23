using DataAccess.Model;
using DataAccess.Repository;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Eventing.Reader;
using System.Reflection.Metadata.Ecma335;
using TrainingAPI.Accesslayer;

namespace TrainingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepo _repo;
        private readonly JwtTokenHandler _jwtTokenHandler;

        public UserController(IUserRepo  repo, JwtTokenHandler jwtTokenHandler)
        {
            this._repo = repo;
            _jwtTokenHandler = jwtTokenHandler;
        }

        [HttpPost]
        [Route("Create")]
        public IActionResult Create(Users users)
        {
            var createdUser=_repo.Add(users);
            return Ok(createdUser);
        }

        [HttpPost]
        [Route("SignIn")]
        public IActionResult Login(string Username, string Password ) {

            var User = _repo.LoggedInUser(Username, Password);
            if (User == null) {
                return BadRequest(); 
                
             }

            var token = _jwtTokenHandler.GetToken(User);
            return Ok(token);

        }



        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpGet]
        [Route("helllllllllllllllllooo")]
        public IActionResult Hello()
        {
 
            return Ok("heeeeeeeeeeellllllllllllllllllllooooooooooooeng ");
        }

    }


}
