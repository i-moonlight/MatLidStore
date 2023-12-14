using MLS.Application.Contracts.Persistence;
using MLS.Domain;
using MLS.Persistence.DatabaseContext;
using MLS.Persistence.Repository.Common;

namespace MLS.Persistence.Repository
{
    public class ReviewRepository : GenericRepository<Review>, IReviewRepository
    {
        public ReviewRepository(MatLidStoreDatabaseContext context) : base(context)
        {
        }
    }
}