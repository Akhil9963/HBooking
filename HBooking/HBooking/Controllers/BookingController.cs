using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace HBooking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly BookingService service;
        public IConfiguration Configuration { get; set; }
        public BookingController(IConfiguration configuration)
        {
            Configuration = configuration;
            service = new BookingService(configuration);
        }
        [HttpGet,Route("order")]
        public IActionResult Order(int id)
        {
            int LoggedInUserId = Convert.ToInt32(User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value);
            service.Create(id,LoggedInUserId);
            return Ok();
        }
        [HttpGet,Route("cancel")]
        public IActionResult Cancel(int id)
        {
            service.Cancel(id);
            return Ok();
        }
        [HttpGet,Route("all")]
        public IActionResult All()
        {
            int LoggedInUserID = Convert.ToInt32(User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value);
            var list=service.GetList(LoggedInUserID);
            return Ok(list);
        }
        [HttpGet]
        public IActionResult Get(int id)
        {
            int LoggedInUserID = Convert.ToInt32(User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value);
            var data = Bookingservice.Get(id, LoggedInUserID);
            return Ok(data);

        }
    }
    internal class Bookingservice
    {
        internal static object Get(int id,int loggedInUserID)
        {
            throw new NotFiniteNumberException();   
        }
    }
    internal class BookingService
    {
        private IConfiguration configuration;   
        public BookingService(IConfiguration configuration)
        {
            this.configuration = configuration;
        }   
        internal void Cancel(int id)
        {
            throw new NotImplementedException();
        }
        internal void Create(int id,int loggedInUserID)
        {
            throw new NotImplementedException();
        }
        internal object GetList(int loggedInUserID)
        {
            throw new NotImplementedException();
        }

    }
}
