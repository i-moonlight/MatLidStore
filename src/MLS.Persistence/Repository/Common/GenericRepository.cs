using MLS.Application.Contracts.Persistence.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLS.Persistence.Repository.Common
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        public async Task<IReadOnlyList<T>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<T> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task Create(T entity)
        {
            throw new NotImplementedException();
        }

        public async Task Update(T entity)
        {
            throw new NotImplementedException();
        }

        public async Task Delete(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
