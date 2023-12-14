using AutoMapper;
using MediatR;
using MLS.Application.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLS.Application.Features.Product.Commands.CreateProductImageCommand
{
    public class CreateProductImageCommandHandler : IRequestHandler<CreateProductImageCommand, int>
    {
        private readonly IProductImageRepository _productImageRepository;
        private readonly IMapper _mapper;

        public CreateProductImageCommandHandler(IProductImageRepository productImageRepository, IMapper mapper)
        {
            _productImageRepository = productImageRepository;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateProductImageCommand request, CancellationToken cancellationToken)
        {
            var productImageToCreate = _mapper.Map<Domain.ProductImage>(request);
            await _productImageRepository.Create(productImageToCreate);

            return productImageToCreate.Id;
        }
    }
}
