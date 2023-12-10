using AutoMapper;
using MediatR;
using MLS.Application.Contracts.Persistence;

namespace MLS.Application.Features.WishList.Commands.UpdateWishListCommand
{
    public class UpdateWishListCommandHandler : IRequestHandler<UpdateWishListCommand, Unit>
    {
        private readonly IWishListRepository _wishListRepository;
        private readonly IMapper _mapper;

        public UpdateWishListCommandHandler(IWishListRepository wishListRepository, IMapper mapper)
        {
            _wishListRepository = wishListRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateWishListCommand request, CancellationToken cancellationToken)
        {
            var wishListToUpdate = _mapper.Map<Domain.WishList>(request);
            await _wishListRepository.Update(wishListToUpdate);

            return Unit.Value;
        }
    }
}