using MediatR;
using MLS.Application.DTO.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLS.Application.Features.Product.Queries.GetAllProduct
{
    public record GetAllProductQuery : IRequest<List<ProductDto>>;
}
