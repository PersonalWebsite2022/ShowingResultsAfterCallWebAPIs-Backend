using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ShowResultBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResultController : ControllerBase
    {
        //https://localhost:40001/swagger/index.html
        [HttpGet("ASimpleTask/{result}")]
        [EnableCors("PolicyAllowAll")]
        public async Task<IActionResult> ASimpleTaskAsync(bool result)
        {
            await Task.Delay(1000);

            if (result)
            {
                StatusCode(StatusCodes.Status200OK);
                return new JsonResult("The task has been done successfully.");
            }
            else
            {
                StatusCode(StatusCodes.Status500InternalServerError);
                return new JsonResult("An error occured. Try it later.");
            }
        }
    }
}
