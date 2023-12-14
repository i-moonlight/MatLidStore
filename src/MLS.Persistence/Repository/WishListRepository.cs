using MLS.Application.Contracts.Persistence;
using MLS.Domain;
using MLS.Persistence.DatabaseContext;
using MLS.Persistence.Repository.Common;

namespace MLS.Persistence.Repository
{
    public class WishListRepository : GenericRepository<WishList>, IWishListRepository
    {
        public WishListRepository(MatLidStoreDatabaseContext context) : base(context)
        {
        }
    }
}