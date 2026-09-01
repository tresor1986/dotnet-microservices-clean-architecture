using Catalog.Application.DTOs.Mappers;
using Catalog.Application.DTOs.Queries;
using Catalog.Application.DTOs.Responses;
using Catalog.Core.Repositories;
using MediatR;

namespace Catalog.Application.DTOs.Handlers
{
    public class GetAllBrandsHandler: IRequestHandler<GetAllBrandsQuery, IList<BrandResponse>>
    {
        private readonly IBrandRepository _brandRepository;
        public GetAllBrandsHandler(IBrandRepository brandRepository)
        {
            _brandRepository = brandRepository;

        }

        public async Task<IList<BrandResponse>> Handle(GetAllBrandsQuery request, CancellationToken cancellationToken)
        {
            var brandList = await _brandRepository.GetAllBrands();
            return brandList.ToResponseList();
        }
    }
}
