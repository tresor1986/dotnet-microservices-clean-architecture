using Catalog.Application.DTOs.Responses;
using Catalog.Core.Specifications;
using MediatR;

namespace Catalog.Application.DTOs.Queries
{
    public record GetAllProductsQuery(CatalogSpecParams CatalogSpecParams ) : IRequest<Pagination<ProductResponse>>
    {
    }
}
