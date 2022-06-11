using AutoMapper;
using KUSYS_Demo.Application.Features.Commands.Authentication.SignUpUser;
using KUSYS_Demo.Application.Models.Authentication.UserModel;
using KUSYS_Demo.Application.Models.Person;
using KUSYS_Demo.Domain.Authentication;
using KUSYS_Demo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KUSYS_Demo.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            #region Authentications

            CreateMap<User, SignUpUserCommand>().ReverseMap();
            CreateMap<User, UserModel>().ReverseMap();

            #endregion

            #region Companies

            CreateMap<Person, PersonModel>().ReverseMap();
            CreateMap<PersonModel, Person>().ReverseMap();

            #endregion
        }
    }
}