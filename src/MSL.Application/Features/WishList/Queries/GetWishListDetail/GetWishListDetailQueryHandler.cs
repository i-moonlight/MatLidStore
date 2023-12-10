using AutoMapper;
using MediatR;
using MLS.Application.Contracts.Persistence;
using MLS.Application.DTO.WishList;
using MLS.Application.Exceptions;

namespace MLS.Application.Features.WishList.Queries.GetWishListDetail
{
    public class GetWishListDetailQueryHandler : IRequestHandler<GetWishListDetailQuery, WishListDetailDto>
    {
        private readonly IWishListRepository _wishListRepository;
        private readonly IMapper _mapper;

        public GetWishListDetailQueryHandler(IWishListRepository wishListRepository, IMapper mapper)
        {
            _wishListRepository = wishListRepository;
            _mapper = mapper;
        }

        public async Task<WishListDetailDto> Handle(GetWishListDetailQuery request, CancellationToken cancellationToken)
        {
            var wishList = await _wishListRepository.GetById(request.Id);
            if (wishList == null)
            {
                throw new NotFoundException(nameof(Domain.WishList), request.Id);
            }

            var data = _mapper.Map<WishListDetailDto>(wishList);

            return data;
        }
    }
}