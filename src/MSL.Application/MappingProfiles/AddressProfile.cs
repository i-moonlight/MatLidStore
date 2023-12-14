using AutoMapper;
using MLS.Application.DTO.Address;
using MLS.Application.Features.Address.Commands.CreateAddressCommand;
using MLS.Application.Features.Address.Commands.DeleteAddressCommand;
using MLS.Application.Features.Address.Commands.UpdateAddressCommand;
using MLS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLS.Application.MappingProfiles
{
    public class AddressProfile : Profile
    {
        public AddressProfile()
        {
            CreateMap<AddressDto, Address>().ReverseMap();
            CreateMap<Address, AddressDetailDto>();
            CreateMap<Address, CreateAddressCommand>();
            CreateMap<Address, UpdateAddressCommand>();
            CreateMap<Address, DeleteAddressCommand>();
        }
    }
}