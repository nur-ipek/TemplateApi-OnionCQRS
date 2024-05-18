using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateApi.Application.Interfaces.AutoMapper;
using TemplateApi.Application.Interfaces.UnitOfWorks;
using TemplateApi.Domain.Entities;

namespace TemplateApi.Application.Features.Products.Command.UpdateProduct
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommandRequest>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public UpdateProductCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task Handle(UpdateProductCommandRequest request, CancellationToken cancellationToken)
        {
            var product = await unitOfWork.GetReadRepository<Product>().GetAsync(x => x.Id == request.Id && !x.IsDeleted );

            var updatedProduct = mapper.Map<Product, UpdateProductCommandRequest>(request);

            var productCategories = await unitOfWork.GetReadRepository<ProductCategory>().GetAllAsync(x => x.ProductId == request.Id);

            //productcategory bağlantılarını kes.
            await unitOfWork.GetWriteRepository<ProductCategory>().HardDeleteRangeAsync(productCategories);

            //productcategory ekle.
            foreach (var item in request.CategoryIds)
            {
                await unitOfWork.GetWriteRepository<ProductCategory>().AddAsync(new ProductCategory()
                {
                    ProductId = request.Id,
                    CategoryId = item
                });
            }

            //product update.
            await unitOfWork.GetWriteRepository<Product>().UpdateAsync(updatedProduct);

            //save async
            await unitOfWork.SaveAsync();
        }
    }
}
