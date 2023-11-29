using MediatR;
using MLS.Application.DTO.Category;

namespace MLS.Application.Features.Category.Queries.GetCategoryDetail
{
    public record GetCategoryDetailQuery(int Id) : IRequest<CategoryDetailDto>;
}