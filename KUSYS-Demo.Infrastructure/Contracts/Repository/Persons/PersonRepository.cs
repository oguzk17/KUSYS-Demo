using KUSYS_Demo.Application.Contracts.Repository.Persons;
using KUSYS_Demo.Domain.Entities;
using KUSYS_Demo.Infrastructure.Contracts.Repository.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KUSYS_Demo.Infrastructure.Contracts.Repository.Persons
{

    public class PersonRepository : RepositoryBase<Person>, IPersonRepository
    {
        public PersonRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}