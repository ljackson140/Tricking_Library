using Microsoft.AspNetCore.Mvc;

namespace TrickingLibraryAPI.Controllers
{
    [ApiController]
    [Route("api/home")]
    public class Home : ControllerBase //Controllersbase gives us API
    {
        [HttpGet]
        public string Index()
        {
            return "Hello World";
        }
        
    }
}