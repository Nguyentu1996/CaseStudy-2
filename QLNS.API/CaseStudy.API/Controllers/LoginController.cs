using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CaseStudy.BAL.Interface;
using CaseStudy.Domain.Response.Login;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CaseStudy.API.Controllers
{

    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginService _login;
        public LoginController(ILoginService login)
        {
            _login = login;
        }
        [HttpGet]
        [Route("api/login/login")]
        public int Login(Login login)
        {
            return _login.Login(login);
        }
    }
}