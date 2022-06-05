using KUSYS_Demo.Application.Features.Queries.Courses.GetCourses;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace KUSYS_Demo.WebAPI.Controllers
{
   // [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {

        public readonly IMediator _mediator;
        public CourseController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCourses()
        {
            return Ok(await _mediator.Send(new GetAllCoursesQuery ()));
        }
    }
}
