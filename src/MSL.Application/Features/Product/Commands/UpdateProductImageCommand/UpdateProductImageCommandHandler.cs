using AutoMapper;
using MediatR;
using MLS.Application.Contracts.Persistence;
using MLS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLS.Application.Features.Product.Commands.UpdateProductImageCommand
{
    public class UpdateProductImageCommandHandler : IRequestHandler<UpdateProductImageCommand, Unit>
    {
        private readonly IProductImageRepository _productImageRepository;
        private readonly IMapper _mapper;

        public UpdateProductImageCommandHandler(IProductImageRepository productImageRepository, IMapper mapper)
        {
            _productImageRepository = productImageRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateProductImageCommand request, CancellationToken cancellationToken)
        {
            var productImageToUpdate = _mapper.Map<ProductImage>(request);
            await _productImageRepository.Update(productImageToUpdate);

            return Unit.Value;
        }
    }
}