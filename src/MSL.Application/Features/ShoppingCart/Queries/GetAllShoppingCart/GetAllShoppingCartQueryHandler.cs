using AutoMapper;
using MediatR;
using MLS.Application.Contracts.Persistence;
using MLS.Application.DTO.ShoppingCart;

namespace MLS.Application.Features.ShoppingCart.Queries.GetAllShoppingCart
{
    public class GetAllShoppingCartQueryHandler : IRequestHandler<GetAllShoppingCartQuery, List<ShoppingCartDto>>
    {
        private readonly IShoppingCartRepository _shoppingCartRepository;
        private readonly IMapper _mapper;

        public GetAllShoppingCartQueryHandler(IShoppingCartRepository shoppingCartRepository, IMapper mapper)
        {
            _shoppingCartRepository = shoppingCartRepository;
            _mapper = mapper;
        }

        public async Task<List<ShoppingCartDto>> Handle(GetAllShoppingCartQuery request, CancellationToken cancellationToken)
        {
            var shoppingCarts = await _shoppingCartRepository.GetAll();
            var data = _mapper.Map<List<ShoppingCartDto>>(shoppingCarts);

            return data;
        }
    }
}