using AutoMapper;
using MediatR;
using MLS.Application.Contracts.Persistence;
using MLS.Application.DTO.CartItem;

namespace MLS.Application.Features.CartItem.Queries.GetCartItemDetail
{
    public class GetCartItemDetailQueryHandler : IRequestHandler<GetCartItemDetailQuery, CartItemDetailDto>
    {
        private readonly ICartItemRepository _cartItemRepository;
        private readonly IMapper _mapper;

        public GetCartItemDetailQueryHandler(ICartItemRepository cartItemRepository, IMapper mapper)
        {
            _cartItemRepository = cartItemRepository;
            _mapper = mapper;
        }

        public async Task<CartItemDetailDto> Handle(GetCartItemDetailQuery request, CancellationToken cancellationToken)
        {
            var cartItem = await _cartItemRepository.GetById(request.Id);
            var data = _mapper.Map<CartItemDetailDto>(cartItem);

            return data;
        }
    }
}