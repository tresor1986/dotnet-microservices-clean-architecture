using Catalog.Application.DTOs.Responses;
using MediatR;

namespace Catalog.Application.DTOs.Queries
{
    public record GetProductsByBrandQuery(string BrandName) : IRequest<List<ProductResponse>>
    {
    }
}
