using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Railway_Reservationsystem_WebAPI.Data;
using Railway_Reservationsystem_WebAPI.Models;

//Train Details Controller
namespace Railway_Reservationsystem_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainDetailsController : ControllerBase
    {
        private readonly LoginDbContext _context;
        public TrainDetailsController(LoginDbContext loginDbContext)
        {
            _context = loginDbContext;

        }
        [HttpGet("TrainDetails")]
        public IActionResult GetUsers()
        {
            var userdetails = _context.TrainDetailsModels.AsQueryable();
            return Ok(new
            {
                StatusCode = 200,

                TrainDetails = userdetails

            });
        }

    }
}
