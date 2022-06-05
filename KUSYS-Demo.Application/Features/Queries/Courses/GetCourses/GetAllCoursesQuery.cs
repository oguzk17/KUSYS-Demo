using KUSYS_Demo.Application.Models.Course;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KUSYS_Demo.Application.Features.Queries.Courses.GetCourses
{
    public  class GetAllCoursesQuery:IRequest<CourseModel>
    {
    }
}
