using MediatR;
using MLS.Application.DTO.Category;
using MLS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLS.Application.Features.Category.Queries.GetAllCategory
{
    public record GetAllCategoryQuery : IRequest<List<CategoryDto>>;
}
