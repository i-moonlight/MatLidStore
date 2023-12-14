using MLS.Application.Contracts.Persistence;
using MLS.Domain;
using MLS.Persistence.DatabaseContext;
using MLS.Persistence.Repository.Common;

namespace MLS.Persistence.Repository
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(MatLidStoreDatabaseContext context) : base(context)
        {
        }
    }
}