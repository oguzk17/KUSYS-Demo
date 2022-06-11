using AutoMapper;
using KUSYS_Demo.Application.Contracts.Repository.Persons;
using KUSYS_Demo.Application.Features.Queries.Courses.GetCourses;
using KUSYS_Demo.Application.Models.Person;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KUSYS_Demo.Application.Features.Queries.Persons.GetPersons
{
    public class GetAllPersonsQueryHandler: IRequestHandler<GetAllPersonsQuery,PersonModel>
    {
        private readonly IPersonRepository _personRepository;
        private readonly IMapper _mapper;

        public GetAllPersonsQueryHandler(IPersonRepository personRepository, IMapper mapper)
        {
            _personRepository = personRepository;
            _mapper = mapper;
        }
        public async Task<PersonModel> Handle(GetAllPersonsQuery request, CancellationToken cancellationToken)
        {
            var courses = await _personRepository.GetAllAsync();

            return _mapper.Map<PersonModel>(courses);

        }
    }
}

 