using AutoMapper;
using BasicMembership.Models;
using BasicMembership.Models.ViewModels;

namespace BasicMembership.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<AppUser, UserListVM>()
                .ForMember(dest => dest.Roles, opt => opt.Ignore());
            CreateMap<AppUser, GetUserVM>()
                .ForMember(dest => dest.Roles, opt => opt.Ignore());
        }
    }
}
