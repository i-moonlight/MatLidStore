using MLS.Application.Contracts.Persistence;
using MLS.Domain;
using MLS.Persistence.DatabaseContext;
using MLS.Persistence.Repository.Common;

namespace MLS.Persistence.Repository
{
    public class DeliveryRepository : GenericRepository<Delivery>, IDeliveryRepository
    {
        public DeliveryRepository(MatLidStoreDatabaseContext context) : base(context)
        {
        }
    }
}