using AutoMapper;
using OnlineMuhasebeServer.Application.Features.AppFeatures.CompanyFeatures.Commands.CreateCompany;
using OnlineMuhasebeServer.Application.Features.AppFeatures.RoleFeatures.Command.CreateRole;
using OnlineMuhasebeServer.Domain.CompanyEntites;
using OnlineMuhasebeServer.Domain.Entities;
using OnlineMuhasebeServer.Domain.Entities.Identity;

namespace OnlineMuhasebeServer.Application.Mapping;
public class MappingProfile:Profile
{
    public MappingProfile()
    {
        CreateMap<CreateCompanyCommand, Company>().ReverseMap();
       //CreateMap<CreateUCAFCommand, UniformChartOfAccount>().ReverseMap();
        CreateMap<CreateRoleCommand, AppRole>().ReverseMap();
    }
}
