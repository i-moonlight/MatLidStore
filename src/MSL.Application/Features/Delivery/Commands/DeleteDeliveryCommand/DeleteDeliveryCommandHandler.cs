using AutoMapper;
using MediatR;
using MLS.Application.Contracts.Persistence;
using MLS.Application.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLS.Application.Features.Delivery.Commands.DeleteDeliveryCommand
{
    public class DeleteDeliveryCommandHandler : IRequestHandler<DeleteDeliveryCommand, Unit>
    {
        private readonly IDeliveryRepository _deliveryRepository;

        public DeleteDeliveryCommandHandler(IDeliveryRepository deliveryRepository)
        {
            _deliveryRepository = deliveryRepository;
        }

        public async Task<Unit> Handle(DeleteDeliveryCommand request, CancellationToken cancellationToken)
        {
            var deliveryToDelete = await _deliveryRepository.GetById(request.Id);

            if (deliveryToDelete == null)
            {
                throw new NotFoundException(nameof(Domain.Delivery), request.Id);
            }

            await _deliveryRepository.Delete(deliveryToDelete);

            return Unit.Value;
        }
    }
}