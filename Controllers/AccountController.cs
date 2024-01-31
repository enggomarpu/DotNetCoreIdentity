using AppIdentity.Dtos;
using AppIdentity.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AppIdentity.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _siginManger;

        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> siginManger)
        {
            _userManager = userManager;
            _siginManger = siginManger;
        }

        [HttpPost("Register")]
        public async Task<ActionResult<UserDto>> Register(RegisterDto regisDto)
        {
            var user = new AppUser
            {
                Email = regisDto.Email,
                FirstName = regisDto.FirstName,
                LastName = regisDto.LastName,
                UserName = regisDto.Email
            };

            var result = await _userManager.CreateAsync(user, regisDto.Password);
            if (!result.Succeeded)
            {
                return BadRequest();
            }

            return new UserDto
            {
                Email = regisDto.Email,
                Token = "This is token value.",
                UserName = regisDto.Email
            };

        }



    }
}
