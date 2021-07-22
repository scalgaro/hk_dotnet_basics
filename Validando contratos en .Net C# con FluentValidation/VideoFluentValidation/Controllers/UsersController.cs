using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using VideoFluentValidation.Contracts.Models;
using VideoFluentValidation.Contracts.Requests;
using VideoFluentValidation.Models;
using VideoFluentValidation.Services;

namespace VideoFluentValidation.Controllers
{
    [ApiController]
    public class UsersController : Controller
    {
        private readonly IUsersService _usersService;
        private readonly IMapper _mapper;

        public UsersController(IUsersService usersService, IMapper mapper)
        {
            _usersService = usersService;
            _mapper = mapper;
        }
        
        [HttpPost("api/v1/users")]
        public IActionResult Post(CreateUserRequest contract)
        {
            var domainEntity = _mapper.Map<User>(contract);

            var user = _usersService.Create(domainEntity);
            
            return Ok(_mapper.Map<UserContract>(user));
        }
    }
}