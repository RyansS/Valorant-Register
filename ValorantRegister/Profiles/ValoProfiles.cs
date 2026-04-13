using AutoMapper;
using ValorantRegister.DTOs;
using ValorantRegister.Model;

namespace ValorantRegister.Profiles
{
    public class ValoProfiles : Profile
    {
        public ValoProfiles ()
        {
            CreateMap<ValoDto, ValoRegister>();
        }
    }
}
