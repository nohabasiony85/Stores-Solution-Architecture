using System;
using AutoMapper;
using Stores.Model;
using Stores.Web.ViewModels;

namespace Stores.Web.Mappings
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Customer, CustomerViewModel>();
            CreateMap<Product, ProductViewModel>();
            CreateMap<Store, StoreViewModel>();
            CreateMap<SoldProduct, SoldProductViewModel>();
            //RecognizePrefix("m_");
        }

        //protected override void Configure()
        //{
        //    Mapper.CreateMap<Customer, CustomerViewModel>();
        //    Mapper.CreateMap<Product, ProductViewModel>();
        //    Mapper.CreateMap<Store, StoreViewModel>();
        //    Mapper.CreateMap<SoldProduct, SoldProductViewModel>();
        //}
    }
}