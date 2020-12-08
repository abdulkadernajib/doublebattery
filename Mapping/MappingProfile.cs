using AutoMapper;
using doublebattery.Controllers.Resources;
using doublebattery.Core.Models;
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
            CreateMap<Product, ProductsResource>()
            .ForMember(pr => pr.Brand, opt => opt.MapFrom(p => p.Model.Brand))
            .ForMember(pr => pr.Category, opt => opt.MapFrom(x => new KeyValuePair { Id = x.CategoryId, Name = x.Category.Name }))
            .ForMember(pr => pr.FrameMaterial, opt => opt.MapFrom(x => new KeyValuePair { Id = x.FrameMaterialId, Name = x.FrameMaterial.Name }))
            .ForMember(pr => pr.TempleMaterial, opt => opt.MapFrom(x => new KeyValuePair { Id = x.TempleMaterialId, Name = x.FrameMaterial.Name }))
            .ForMember(pr => pr.LensMaterial, opt => opt.MapFrom(x => new KeyValuePair { Id = x.LensMaterialId, Name = x.LensMaterial.Name }))
            .ForMember(pr => pr.TempleColor, opt => opt.MapFrom(x => new KeyValuePair { Id = x.TempleColorId, Name = x.FrameColor.Name }))
            .ForMember(pr => pr.FrameColor, opt => opt.MapFrom(x => new KeyValuePair { Id = x.FrameColorId, Name = x.FrameColor.Name }))
            .ForMember(pr => pr.LensColor, opt => opt.MapFrom(x => new KeyValuePair { Id = x.LensColorId, Name = x.LensColor.Name }))
            .ForMember(pr => pr.Style, opt => opt.MapFrom(x => new KeyValuePair { Id = x.StyleId, Name = x.Style.Name }))
            .ForMember(pr => pr.IdealFor, opt => opt.MapFrom(x => new KeyValuePair { Id = x.IdealForId, Name = x.IdealFor.Name }))
            .ForMember(pr => pr.FrameType, opt => opt.MapFrom(x => new KeyValuePair { Id = x.FrameTypeId, Name = x.FrameType.Name }))
            .ForMember(pr => pr.Size, opt => opt.MapFrom(x => new KeyValuePair { Id = x.SizeId, Name = x.Size.Name }));

            // API Resource -> Domain Class
            CreateMap<ModelResource, Model>();
            CreateMap<ProductQueryResource, ProductQuery>();
            CreateMap<SaveProductResource, Product>()
            .ForMember(p => p.Id, opt => opt.Ignore());

        }
    }
}