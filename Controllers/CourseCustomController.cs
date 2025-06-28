using LAB12_REYES.Data;
using LAB12_REYES.Responses;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LAB12_REYES.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseCustomController : ControllerBase
    {

        private readonly DBContext _context;

        public CourseCustomController(
            DBContext context
            )
        {
            this._context = context;
        }

        [HttpGet]
        public List<CourseResponseV1> GetCourses()
        {
            var courses =this._context.Courses
                .Where(c => !c.IsDeleted)
                .Select(c => new CourseResponseV1
                {
                    CourseID = c.CourseID,
                    Name = c.Name,
                    Credit = c.Credit
                })
                .ToList();
            return courses;
        }
    }
}
