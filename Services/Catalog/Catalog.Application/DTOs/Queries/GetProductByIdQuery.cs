using Catalog.Application.DTOs.Responses;
using MediatR;

namespace Catalog.Application.DTOs.Queries
{
    public record GetProductByIdQuery(string Id) : IRequest<ProductResponse>
    {
    }
}
