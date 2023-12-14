using AutoMapper;
using MLS.Application.DTO.Shipping;
using MLS.Application.Features.Shipping.Commands.CreateShippingCommand;
using MLS.Application.Features.Shipping.Commands.DeleteShippingCommand;
using MLS.Application.Features.Shipping.Commands.UpdateShippingCommand;
using MLS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLS.Application.MappingProfiles
{
    public class ShippingProfile : Profile
    {
        public ShippingProfile()
        {
            CreateMap<ShippingDto, Shipping>().ReverseMap();
            CreateMap<Shipping, ShippingDetailDto>();
            CreateMap<Shipping, CreateShippingCommand>();
            CreateMap<Shipping, UpdateShippingCommand>();
            CreateMap<Shipping, DeleteShippingCommand>();
        }
    }
}
