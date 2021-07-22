using AutoMapper;
using VideoFluentValidation.Contracts.Models;
using VideoFluentValidation.Contracts.Requests;
using VideoFluentValidation.Models;

namespace VideoFluentValidation.Mapping
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserContract>().ReverseMap();
            CreateMap<User, CreateUserRequest>().ReverseMap();
        }
    }
}