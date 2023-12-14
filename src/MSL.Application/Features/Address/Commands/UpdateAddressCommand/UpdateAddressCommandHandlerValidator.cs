using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLS.Application.Features.Address.Commands.UpdateAddressCommand
{
    public class UpdateAddressCommandHandlerValidator : AbstractValidator<UpdateAddressCommand>
    {
        public UpdateAddressCommandHandlerValidator()
        {
            RuleFor(x => x.Street)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(200).WithMessage("{PropertyName} must be fewer than 200 characters.");
            RuleFor(x => x.City)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(20).WithMessage("{PropertyName} must be fewer than 20 characters.");
            RuleFor(x => x.Country)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(50).WithMessage("{PropertyName} must be fewer than 50 characters.");
            RuleFor(x => x.ZipCode)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(15).WithMessage("{PropertyName} must be fewer than 15 characters.");
        }
    }
}
