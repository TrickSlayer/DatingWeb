using API.Data;
using API.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseApiController : ControllerBase
    {
        protected readonly DatingAppContext _context;
        protected readonly ITokenService _tokenService;
        public BaseApiController(DatingAppContext context, ITokenService tokenService)
        {
            _context = context;
            _tokenService = tokenService;
        }

        public BaseApiController(DatingAppContext context)
        {
            _context = context;
        }
    }
}
