using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using TemplateApi.Domain.Common;

namespace TemplateApi.Domain.Entities
{
    public class Product: EntityBase
    {
        public required string Title { get; set; }
        public required string Description { get; set; }
        public required int BrandId { get; set; }
        public required decimal Price { get; set; }
        public required decimal Discount { get; set; }
        public Brand Brand { get; set; }

        //Bir ürünün category ile çoka çok ilişki de olması gerekli !
        public ICollection<Category> Categories { get; set; }

    }
}
