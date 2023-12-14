using MediatR;

namespace MLS.Application.Features.Address.Commands.UpdateAddressCommand
{
    public class UpdateAddressCommand : IRequest<Unit>
    {
        public string Street { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string ZipCode { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
    }
}