﻿using MLS.Application.Contracts.Persistence;
using MLS.Domain;
using MLS.Persistence.Repository.Common;

namespace MLS.Persistence.Repository
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
    }
}