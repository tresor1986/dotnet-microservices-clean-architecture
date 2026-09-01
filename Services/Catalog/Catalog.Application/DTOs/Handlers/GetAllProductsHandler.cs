using Catalog.Application.DTOs.Mappers;
using Catalog.Application.DTOs.Queries;
using Catalog.Application.DTOs.Responses;
using Catalog.Core.Repositories;
using Catalog.Core.Specifications;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Catalog.Application.DTOs.Handlers
{
    public class GetAllProductsHandler : IRequestHandler<GetAllProductsQuery, Pagination<ProductResponse>>
    {
        //DIP
        private readonly IProductRepository _productRepository;
        private readonly ILogger<GetAllProductsHandler> _logger;
        public GetAllProductsHandler(IProductRepository productRepository, ILogger<GetAllProductsHandler> logger)
        {
            _productRepository = productRepository;
            _logger = logger;


        }

        public async Task<Pagination<ProductResponse>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            var productList = await _productRepository.GetProducts(request.CatalogSpecParams);
            var productResponseList = productList.ToResPonse();
            return productResponseList;

        }
    }
}
