using AutoMapper;
using Northwind.API.Models;
using Northwind.API.ViewModels;

namespace Northwind.API.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Employee,EmployeeViewModel>();
            // CreateMap<Make, MakeViewModel>();
            // CreateMap<Model, ModelViewModel>();
        }
    }
}