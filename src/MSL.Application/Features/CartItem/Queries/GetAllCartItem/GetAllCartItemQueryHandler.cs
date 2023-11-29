using AutoMapper;
using MediatR;
using MLS.Application.Contracts.Persistence;
using MLS.Application.DTO.CartItem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLS.Application.Features.CartItem.Queries.GetAllCartItem
{
    public class GetAllCartItemQueryHandler : IRequestHandler<GetAllCartItemQuery, List<CartItemDto>>
    {
        private readonly ICartItemRepository _cartItemRepository;
        private readonly IMapper _mapper;

        public GetAllCartItemQueryHandler(ICartItemRepository cartItemRepository, IMapper mapper)
        {
            _cartItemRepository = cartItemRepository;
            _mapper = mapper;
        }

        public async Task<List<CartItemDto>> Handle(GetAllCartItemQuery request, CancellationToken cancellationToken)
        {
            var cartItems = await _cartItemRepository.GetAll();
            var data = _mapper.Map<List<CartItemDto>>(cartItems);

            return data;
        }
    }
}
