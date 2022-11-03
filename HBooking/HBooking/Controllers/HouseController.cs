using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace HBooking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HouseController : ControllerBase
    {
        private readonly HouseService service;
        public IConfiguration Configuration { get; } 
        public HouseController(IConfiguration configuration)
        {
            Configuration = configuration;
            service = new HouseService(Configuration);
        }
        [HttpGet,Route("all")]
        public IActionResult GetAll()
        {
            int LoggedInUserID = Convert.ToInt32(User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value);
            var data = service.GetList(LoggedInUserID);
            return Ok(data);
        }
        [HttpPost]
        public IActionResult Post(HouseVM houseVM)
        {
            int LoggedInUserID = Convert.ToInt32(User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value);
            service.Create(houseVM,LoggedInUserID);
            return Ok();
        }
        public string LoggedInUserEmail => Convert.ToString(User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Email)?.Value);

    }
    public class HouseVM
    {

    }
    internal class HouseService
    {
        private IConfiguration configuration;   
        public HouseService(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        internal void Create(HouseVM houseVM,int loggedInUserID)
        {
            throw new NotImplementedException();
        }
        internal object GetList(int loggedInUserID)
        {
            throw new NotImplementedException();
        }
    }
}
