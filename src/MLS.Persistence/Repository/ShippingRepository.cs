using MLS.Application.Contracts.Persistence;
using MLS.Domain;
using MLS.Persistence.DatabaseContext;
using MLS.Persistence.Repository.Common;

namespace MLS.Persistence.Repository
{
    public class ShippingRepository : GenericRepository<Shipping>, IShippingRepository
    {
        public ShippingRepository(MatLidStoreDatabaseContext context) : base(context)
        {
        }
    }
}