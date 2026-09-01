using Catalog.Application.DTOs.Responses;
using Catalog.Core.Entities;

namespace Catalog.Application.DTOs.Mappers
{
    public static class TypeMapper
    {
        public static TypesResponses ToResponse(this ProductType type)
        {
            return new TypesResponses
            {
                Id = type.Id,
                Name = type.Name
            };
        }

        public static IList<TypesResponses> ToResponseList( this IEnumerable<ProductType> types)
        {
            return types.Select(t => t.ToResponse()).ToList();
        }
    }
}
