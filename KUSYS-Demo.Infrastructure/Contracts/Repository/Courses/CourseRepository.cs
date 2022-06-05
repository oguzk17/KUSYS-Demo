using KUSYS_Demo.Application.Contracts.Repository.Courses;
using KUSYS_Demo.Domain.Entities;
using KUSYS_Demo.Infrastructure.Contracts.Repository.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KUSYS_Demo.Infrastructure.Contracts.Repository.Courses
{
    public class CourseRepository : RepositoryBase<Course>, ICourseRepository
    {
        public CourseRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
