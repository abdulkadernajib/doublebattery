using AutoMapper;
using doublebattery.Controllers.Resources;
using doublebattery.Models;

namespace doublebattery.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Domain Class -> API Resource
            CreateMap<Brand, BrandResource>();
            CreateMap<Model, ModelResource>();
            CreateMap<Product, SaveProductResource>();

            // API Resource -> Domain Class
            CreateMap<ModelResource, Model>();
            CreateMap<SaveProductResource, Product>()
            .ForMember(v => v.Id, opt => opt.Ignore());

        }
    }
}