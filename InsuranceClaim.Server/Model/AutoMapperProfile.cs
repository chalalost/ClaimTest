using AutoMapper;
using InsuranceClaim.Server.Data.Entities;
using InsuranceClaim.Server.Model.DTOs;

namespace InsuranceClaim.Server.Model
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() {
            CreateMap<Claim, ClaimSubmissionDto>()
                .ForMember(d => d.CustomerName, opt => opt.MapFrom(src => src.CustomerName))
                .ForMember(d => d.ClaimAmount, opt => opt.MapFrom(src => src.ClaimAmount));
        }
    }
}
