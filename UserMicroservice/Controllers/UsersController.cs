using Microsoft.AspNetCore.Mvc;
using UserMicroservice.Model;
using UserMicroservice.Services.Interface;

namespace UserMicroservice.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService userService;
        public UsersController(IUserService _userService)
        {
            userService = _userService;
        }

        [HttpGet]
        public IEnumerable<User> UserList()
        {
            User product = new User();
            product.Address = "a";
            product.UserId = 2;
            product.UserName = "aa";
            return (IEnumerable<User>)product;
        }
    }
}
