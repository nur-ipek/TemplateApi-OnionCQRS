using Bogus;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TemplateApi.Domain.Entities;

namespace TemplateApi.Persistence.Configurations
{
    public class BrandConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.Property(x => x.Name).HasMaxLength(256);
            
            Faker faker = new ("tr");

            Brand brand1 = new Brand()
            { 
                Id=1,
                Name= faker.Commerce.Department(),
                CreatedDate = DateTime.Now,
                IsDeleted = false
            }; 
            Brand brand2 = new Brand()
            {
                Id = 2,
                Name = faker.Commerce.Department(),
                CreatedDate = DateTime.Now,
                IsDeleted = false
            }; 
            Brand brand3 = new Brand()
            {
                Id = 3,
                Name = faker.Commerce.Department(),
                CreatedDate = DateTime.Now,
                IsDeleted = true
            };

            builder.HasData(brand1,brand2,brand3);
        }


    }
}
