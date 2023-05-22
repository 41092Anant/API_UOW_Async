using API.Model;
using API.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;       

        public WeatherForecastController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }      

        [HttpGet]       
        public async Task<IActionResult> GetContact()
        {
            var contact = await unitOfWork.Person.GetAll();
            if (contact == null)
            {
                return NotFound();
            }
            return Ok(contact);
        }
    }
}