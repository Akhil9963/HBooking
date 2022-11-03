using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HBooking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomsController : ControllerBase
    {
        private readonly RoomsService service;
        public IConfiguration Configuration { get; set; }   
        public RoomsController(IConfiguration configuration)
        {
            Configuration = configuration;
            service = new RoomsService(configuration);
        }
        [HttpGet]
        public IActionResult Get(int itemId)
        {
            var data = service.GetRoom(itemId);
            return Ok(data);
        }
        [HttpGet,Route("all")]
        public IActionResult GetAll(int BookingId)
        {
            var data = service.Booking(BookingId, false);
            return Ok(data);
        }
        [HttpPost]
        public IActionResult Post(RoomVM roomVM)
        {
            RoomsService.Create(roomVM);
            return Ok();
        }
        [HttpPost,Route("update")]
        public IActionResult Update(RoomVM roomVM)
        {
            service.Update(roomVM);
            return Ok();
        }
        [HttpGet,Route("search")]
        [AllowAnonymous]
        public IActionResult Search(string term)
        {
            var data=service.Search(term);
            return Ok(data);
        }
    }
    public class RoomVM
    {

    }
    internal class RoomsService
    {
        private IConfiguration configuration;
        public RoomsService(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        internal static void Create(RoomVM roomVM)
        {
            throw new NotImplementedException();
        }
        internal object Booking(int bookingId,bool v)
        {
            throw new NotImplementedException();
        }
        internal object GetRoom(int itemId)
        {
            throw new NotImplementedException();
        }
        internal object Search(string term)
        {
            throw new NotImplementedException();
        }
        internal void Update(RoomVM roomVM)
        {
            throw new NotImplementedException();
        }
    }
}
