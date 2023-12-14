using MLS.Application.Contracts.Persistence;
using MLS.Domain;
using MLS.Persistence.DatabaseContext;
using MLS.Persistence.Repository.Common;

namespace MLS.Persistence.Repository
{
    public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(MatLidStoreDatabaseContext context) : base(context)
        {
        }
    }
}