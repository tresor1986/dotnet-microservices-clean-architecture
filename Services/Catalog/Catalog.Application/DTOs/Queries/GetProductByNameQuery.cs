using Catalog.Application.DTOs.Responses;
using MediatR;

namespace Catalog.Application.DTOs.Queries
{
    public record GetProductByNameQuery(string name) : IRequest<IList<ProductResponse>>
    {
    }
}
