using AutoMapper;
using Stores.Model;
using Stores.Web.ViewModels;

namespace Stores.Web.Mappings
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        public ViewModelToDomainMappingProfile()
        {
            CreateMap<CustomerViewModel, Customer>()
                .ForMember(g => g.Name, map => map.MapFrom(vm => vm.Name))
                .ForMember(g => g.Address, map => map.MapFrom(vm => vm.Address));

            CreateMap<ProductViewModel, Product>()
    .ForMember(g => g.Name, map => map.MapFrom(vm => vm.Name))
    .ForMember(g => g.Price, map => map.MapFrom(vm => vm.Price));

            CreateMap<StoreViewModel, Store>()
    .ForMember(g => g.Name, map => map.MapFrom(vm => vm.Name))
    .ForMember(g => g.Address, map => map.MapFrom(vm => vm.Address));

            CreateMap<SoldProductViewModel, SoldProduct>()
    .ForMember(g => g.SoldDate, map => map.MapFrom(vm => vm.SoldDate))
    .ForMember(g => g.CustomerId, map => map.MapFrom(vm => vm.CustomerId))
    .ForMember(g => g.Customer, map => map.MapFrom(vm => vm.Customer))
    .ForMember(g => g.Product, map => map.MapFrom(vm => vm.Product))
    .ForMember(g => g.ProductId, map => map.MapFrom(vm => vm.ProductId))
    .ForMember(g => g.Store, map => map.MapFrom(vm => vm.Store))
    .ForMember(g => g.StoreId, map => map.MapFrom(vm => vm.StoreId));

        }

        //protected override void Configure()
        //{
        //    //Mapper.CreateMap<CustomerViewModel, Customer>()
        //    //    .ForMember(g => g.Name, map => map.MapFrom(vm => vm.GadgetTitle))
        //    //    .ForMember(g => g.Description, map => map.MapFrom(vm => vm.GadgetDescription))
        //    //    .ForMember(g => g.Price, map => map.MapFrom(vm => vm.GadgetPrice))
        //    //    .ForMember(g => g.Image, map => map.MapFrom(vm => vm.File.FileName))
        //    //    .ForMember(g => g.CategoryID, map => map.MapFrom(vm => vm.GadgetCategory));
        //}
    }
}