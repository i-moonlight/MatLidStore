using MediatR;

namespace MLS.Application.Features.Category.Commands.DeleteCategoryCommand
{
    public class DeleteCategoryCommand : IRequest<Unit>
    {
        public int Id { get; set; }
    }
}
