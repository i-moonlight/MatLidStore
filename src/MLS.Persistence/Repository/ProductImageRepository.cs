using MLS.Application.Contracts.Persistence;
using MLS.Domain;
using MLS.Persistence.DatabaseContext;
using MLS.Persistence.Repository.Common;

namespace MLS.Persistence.Repository
{
    public class ProductImageRepository : GenericRepository<ProductImage>, IProductImageRepository
    {
        public ProductImageRepository(MatLidStoreDatabaseContext context) : base(context)
        {
        }
    }
}