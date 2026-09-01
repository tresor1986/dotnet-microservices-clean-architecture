using Catalog.Application.DTOs.Mappers;
using Catalog.Application.DTOs.Queries;
using Catalog.Application.DTOs.Responses;
using Catalog.Core.Repositories;
using MediatR;

namespace Catalog.Application.DTOs.Handlers
{
    public class GetProductByIdHandler : IRequestHandler<GetProductByIdQuery, ProductResponse>
    {
        private readonly IProductRepository _productRepository;
        public GetProductByIdHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task<ProductResponse> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var product = await _productRepository.GetProduct(request.Id);
            var productResponse = product.ToResponse();
            return productResponse;
        }
    }
}
