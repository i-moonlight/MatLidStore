using AutoMapper;
using MLS.Application.DTO.Payment;
using MLS.Application.Features.Payment.Commands.CreatePaymentCommand;
using MLS.Application.Features.Payment.Commands.DeletePaymentCommand;
using MLS.Application.Features.Payment.Commands.UpdatePaymentCommand;
using MLS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLS.Application.MappingProfiles
{
    public class PaymentProfile : Profile
    {
        public PaymentProfile()
        {
            CreateMap<PaymentDto, Payment>().ReverseMap();
            CreateMap<Payment, PaymentDetailDto>();
            CreateMap<Payment, CreatePaymentCommand>();
            CreateMap<Payment, UpdatePaymentCommand>();
            CreateMap<Payment, DeletePaymentCommand>();
        }
    }
}
