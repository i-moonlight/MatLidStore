using MLS.Application.Contracts.Persistence.Common;
using MLS.Domain;

namespace MLS.Application.Contracts.Persistence
{
    public interface IEmployeeRepository : IGenericRepository<Employee>
    {
    }
}