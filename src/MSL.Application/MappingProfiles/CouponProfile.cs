using AutoMapper;
using MLS.Application.DTO.Coupon;
using MLS.Application.Features.Coupon.Commands.CreateCouponCommand;
using MLS.Application.Features.Coupon.Commands.DeleteCouponCommand;
using MLS.Application.Features.Coupon.Commands.UpdateCouponCommand;
using MLS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLS.Application.MappingProfiles
{
    public class CouponProfile : Profile
    {
        public CouponProfile()
        {
            CreateMap<CouponDto, Coupon>().ReverseMap();
            CreateMap<Coupon, CouponDetailDto>();
            CreateMap<Coupon, CreateCouponCommand>();
            CreateMap<Coupon, UpdateCouponCommand>();
            CreateMap<Coupon, DeleteCouponCommand>();
        }
    }
}
