using AutoMapper;
using MediatR;
using MLS.Application.Contracts.Persistence;
using MLS.Application.DTO.ShoppingCart;
using MLS.Application.Exceptions;

namespace MLS.Application.Features.ShoppingCart.Queries.GetShoppingCartDetail
{
    public class GetShoppingCartDetailQueryHandler : IRequestHandler<GetShoppingCartDetailQuery, ShoppingCartDetailDto>
    {
        private readonly IShoppingCartRepository _shoppingCartRepository;
        private readonly IMapper _mapper;

        public GetShoppingCartDetailQueryHandler(IShoppingCartRepository shoppingCartRepository, IMapper mapper)
        {
            _shoppingCartRepository = shoppingCartRepository;
            _mapper = mapper;
        }

        public async Task<ShoppingCartDetailDto> Handle(GetShoppingCartDetailQuery request, CancellationToken cancellationToken)
        {
            var shoppingCart = await _shoppingCartRepository.GetById(request.Id);

            if (shoppingCart == null)
            {
                throw new NotFoundException(nameof(Domain.ShoppingCart), request.Id);
            }

            var data = _mapper.Map<ShoppingCartDetailDto>(shoppingCart);

            return data;
        }
    }
}