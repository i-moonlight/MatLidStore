using MLS.Application.Contracts.Persistence;
using MLS.Domain;
using MLS.Persistence.DatabaseContext;
using MLS.Persistence.Repository.Common;

namespace MLS.Persistence.Repository
{
    public class OrderHistoryRepository : GenericRepository<OrderHistory>, IOrderHistoryRepository
    {
        public OrderHistoryRepository(MatLidStoreDatabaseContext context) : base(context)
        {
        }
    }
}