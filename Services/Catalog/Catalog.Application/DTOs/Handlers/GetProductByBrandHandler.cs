using Catalog.Application.DTOs.Mappers;
using Catalog.Application.DTOs.Queries;
using Catalog.Application.DTOs.Responses;
using Catalog.Core.Repositories;
using MediatR;

namespace Catalog.Application.DTOs.Handlers
{
    public class GetProductByBrandHandler : IRequestHandler<GetProductsByBrandQuery, IList<ProductResponse>>
    {
        private readonly IProductRepository _productRepository;
        public GetProductByBrandHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task<IList<ProductResponse>> Handle(GetProductsByBrandQuery request, CancellationToken cancellationToken)
        {
            var productList = await _productRepository.GetProductsByBrand(request.BrandName);
            return productList.ToResponseList();
        }
    }
}
