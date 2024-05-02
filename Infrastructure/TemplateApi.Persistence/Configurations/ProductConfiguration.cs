using Bogus;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateApi.Domain.Entities;

namespace TemplateApi.Persistence.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            Faker faker = new("tr");

            Product product = new Product()
            {
                Id = 1,
                Title = faker.Commerce.ProductName(),
                Price = faker.Finance.Amount(10, 1000),
                Description = faker.Commerce.ProductDescription(),
                BrandId = 1,
                Discount = faker.Random.Decimal(0, 10),
                CreatedDate = DateTime.Now,
                IsDeleted = false
            };


            Product product2 = new Product()
            {
                Id = 2,
                Title = faker.Commerce.ProductName(),
                Price = faker.Finance.Amount(10, 1000),
                Description = faker.Commerce.ProductDescription(),
                BrandId = 3,
                Discount = faker.Random.Decimal(0, 10),
                CreatedDate = DateTime.Now,
                IsDeleted = false
            };

            builder.HasData(product, product);
        }
    }
}
