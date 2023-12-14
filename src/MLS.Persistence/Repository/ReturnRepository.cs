using MLS.Application.Contracts.Persistence;
using MLS.Domain;
using MLS.Persistence.DatabaseContext;
using MLS.Persistence.Repository.Common;

namespace MLS.Persistence.Repository
{
    public class ReturnRepository : GenericRepository<Return>, IReturnRepository
    {
        public ReturnRepository(MatLidStoreDatabaseContext context) : base(context)
        {
        }
    }
}