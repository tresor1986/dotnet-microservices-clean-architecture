using Catalog.Application.DTOs.Mappers;
using Catalog.Application.DTOs.Queries;
using Catalog.Application.DTOs.Responses;
using Catalog.Core.Repositories;
using MediatR;

namespace Catalog.Application.DTOs.Handlers
{
    public class GetProductByNameHandler : IRequestHandler<GetProductByNameQuery, IList<ProductResponse>>
    {
        private readonly IProductRepository _productRepository;
        public GetProductByNameHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task<IList<ProductResponse>> Handle(GetProductByNameQuery request, CancellationToken cancellationToken)
        {
            var productList = await _productRepository.GetProductsByName(request.name);
            var productResponseList = productList.ToResponseList();
            return productResponseList;
        }
    }
}
