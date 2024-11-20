using AutoMapper;
using InsuranceClaim.Server.Model.DTOs;
using InsuranceClaim.Server.Model.Entities;

namespace InsuranceClaim.Server.Model
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() {
            CreateMap<Claim, ClaimSubmissionDto>()
                .ForMember(d => d.CreatedDate, opt => opt.MapFrom(src => src.ClaimDate))
                .ForMember(d => d.CustomerName, opt => opt.MapFrom(src => src.CustomerName))
                .ForMember(d => d.ClaimAmount, opt => opt.MapFrom(src => src.ClaimAmount));
        }
    }
}
