using MLS.Application.Contracts.Persistence;
using MLS.Domain;
using MLS.Persistence.DatabaseContext;
using MLS.Persistence.Repository.Common;

namespace MLS.Persistence.Repository
{
    public class ShoppingCartRepository : GenericRepository<ShoppingCart>, IShoppingCartRepository
    {
        public ShoppingCartRepository(MatLidStoreDatabaseContext context) : base(context)
        {
        }
    }
}