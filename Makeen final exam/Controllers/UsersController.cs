using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Makeen_final_exam.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Makeen_final_exam.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    [AllowAnonymous]
    public class UsersController : Controller
    {
        private readonly IUserServices _userServices;

        public UsersController(IUserServices userServices)
        {
            _userServices = userServices; 
        }
    }
}
