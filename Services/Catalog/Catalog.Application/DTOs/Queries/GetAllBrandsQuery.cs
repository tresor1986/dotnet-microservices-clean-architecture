using Catalog.Application.DTOs.Responses;
using MediatR;

namespace Catalog.Application.DTOs.Queries
{
    public record GetAllBrandsQuery : IRequest<IList<BrandResponse>>
    {
    }
}
