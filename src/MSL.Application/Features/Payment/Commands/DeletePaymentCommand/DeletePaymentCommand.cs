﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLS.Application.Features.Payment.Commands.DeletePaymentCommand
{
    public class DeletePaymentCommand : IRequest<Unit>
    {
        public int Id { get; set; }
    }
}