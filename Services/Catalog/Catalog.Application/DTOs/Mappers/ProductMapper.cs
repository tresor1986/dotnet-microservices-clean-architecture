using Catalog.Application.Commands;
using Catalog.Application.DTOs;
using Catalog.Application.DTOs.Responses;
using Catalog.Core.Entities;
using Catalog.Core.Specifications;

namespace Catalog.Application.DTOs.Mappers
{
    public static class ProductMapper
    {
        public static ProductResponse ToResponse( this Product product) 
        {
            if (product == null) return null;
            return new ProductResponse
            {
                Id = product.Id,
                Name = product.Name,
                Summary = product.Summary,
                Description = product.Description,
                ImageFile = product.ImageFile,
                Brand = product.Brand,
                Type = product.Type,
                Price = product.Price,
                CreateDate = product.CreateDate,
            };

        }

        public static Pagination<ProductResponse> ToResPonse(this Pagination<Product> pagination)
            => new Pagination<ProductResponse>(
                   pagination.PageIndex,
                   pagination.PageSize,
                   pagination.Count,
                   pagination.Data.Select(p => p.ToResponse()).ToList()

                );

        public static IList<ProductResponse> ToResponseList(this IEnumerable<Product> products)
          => products.Select(p => p.ToResponse()).ToList();

        public static Product ToEntity(this CreateProductCommand command, ProductBrand brand, ProductType type)
             => new Product
             {
                 Name = command.Name,
                 Summary = command.Summary,
                 Description = command.Description,
                 ImageFile = command.ImageFile,
                 Brand = brand,
                 Type = type,
                 Price = command.Price,
                 CreateDate = DateTimeOffset.UtcNow
             };


        public static Product ToUpdateEntity(this UpdateProductCommand command, Product existing, ProductBrand brand, ProductType type)
        {
            return new Product
            {
                Id = existing.Id,
                Name = command.Name,
                Summary = command.Summary,
                ImageFile = command.ImageFile,
                Brand = brand,
                Type = type,
                Price = command.Price, 
                CreateDate = existing.CreateDate,
                Description = command.Description
            };
        }
        //public static ProductDto ToDto(this ProductResponse product)
        //{
        //    if (product == null) return null;
        //    return new ProductDto
        //    (
        //        product.Id,
        //        product.Name,
        //        product.Summary,
        //        product.Description,
        //        product.ImageFile,
        //        product.Price,
        //        DateTimeOffset.UtcNow
                

        //    );
        //}
    }
}
