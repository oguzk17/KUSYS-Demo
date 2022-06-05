using AutoMapper;
using KUSYS_Demo.Application.Contracts.Repository.Courses;
using KUSYS_Demo.Application.Models.Course;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KUSYS_Demo.Application.Features.Queries.Courses.GetCourses
{
    public class GetAllCoursesQueryHandler : IRequestHandler<GetAllCoursesQuery, CourseModel>
    {

        private readonly ICourseRepository _courseRepository;
        private readonly IMapper _mapper;

        public GetAllCoursesQueryHandler(ICourseRepository courseRepository, IMapper mapper)
        {
            _courseRepository = courseRepository;
            _mapper = mapper;
        }
        public async Task<CourseModel> Handle(GetAllCoursesQuery request, CancellationToken cancellationToken)
        {
            var courses = await _courseRepository.GetAllAsync();

            return _mapper.Map<CourseModel>(courses);

            }

    }
}

    

