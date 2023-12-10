using MediatR;
using MLS.Application.DTO.Category;

namespace MLS.Application.Features.Category.Queries.GetAllCategory
{
    public record GetAllCategoryQuery : IRequest<List<CategoryDto>>;
}