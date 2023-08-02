using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace app_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {

        [HttpGet]
        public IEnumerable<string> GetCourseDetails()
        {
            return new string[] { "Aws", "Azure" };
        }

        
    }
}
