using MediatR;

namespace MLS.Application.Features.Address.Commands.CreateAddressCommand
{
    public class CreateAddressCommand : IRequest<int>
    {
        public int UserId { get; set; }
        public string Street { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string ZipCode { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
    }
}