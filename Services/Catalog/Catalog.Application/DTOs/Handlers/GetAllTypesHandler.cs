using Catalog.Application.DTOs.Mappers;
using Catalog.Application.DTOs.Queries;
using Catalog.Application.DTOs.Responses;
using Catalog.Core.Repositories;
using MediatR;

namespace Catalog.Application.DTOs.Handlers
{
    public class GetAllTypesHandler : IRequestHandler<GetAllTypesQuery, IList<TypesResponses>>
    {
        private readonly ITypeRepository _typesRepoistory;
        public GetAllTypesHandler(ITypeRepository typeRepository)
        {
            _typesRepoistory = typeRepository;
        }

        public async Task<IList<TypesResponses>> Handle(GetAllTypesQuery request, CancellationToken cancellationToken)
        {
            var typesList = await _typesRepoistory.GetAllTypes();
            return typesList.ToResponseList();
        }
    }
}
