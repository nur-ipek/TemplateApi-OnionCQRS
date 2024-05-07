using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateApi.Application.Features.Products.Queries.GetAllProducts
{
    public class GetAllProductsQueryResponse
    {
        public required string Title { get; set; }
        public required string Description { get; set; }
        public required decimal Price { get; set; }
        public required decimal Discount { get; set; }
    }
}
