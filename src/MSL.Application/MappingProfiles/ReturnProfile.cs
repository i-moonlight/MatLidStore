using AutoMapper;
using MLS.Application.DTO.Return;
using MLS.Application.Features.Return.Commands.CreateReturnCommand;
using MLS.Application.Features.Return.Commands.DeleteReturnCommand;
using MLS.Application.Features.Return.Commands.UpdateReturnCommand;
using MLS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLS.Application.MappingProfiles
{
    public class ReturnProfile : Profile
    {
        public ReturnProfile()
        {
            CreateMap<ReturnDto, Return>().ReverseMap();
            CreateMap<Return, ReturnDetailDto>();
            CreateMap<Return, CreateReturnCommand>();
            CreateMap<Return, UpdateReturnCommand>();
            CreateMap<Return, DeleteReturnCommand>();
        }
    }
}
