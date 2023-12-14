using AutoMapper;
using MediatR;
using MLS.Application.Contracts.Persistence;

namespace MLS.Application.Features.WishList.Commands.CreateWishListCommand
{
    public class CreateWishListCommandHandler : IRequestHandler<CreateWishListCommand, int>
    {
        private readonly IWishListRepository _wishListRepository;
        private readonly IMapper _mapper;

        public CreateWishListCommandHandler(IWishListRepository wishListRepository, IMapper mapper)
        {
            _wishListRepository = wishListRepository;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateWishListCommand request, CancellationToken cancellationToken)
        {
            var wishListToCreate = _mapper.Map<Domain.WishList>(request);
            await _wishListRepository.Create(wishListToCreate);

            return wishListToCreate.Id;
        }
    }
}