using API.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseApiController : ControllerBase
    {
        protected readonly DatingAppContext _context;
        public BaseApiController(DatingAppContext context)
        {
            _context = context;
        }
    }
}
