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
        public string Title { get; set; }
        public string Description { get; set; }
        public int BrandId { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public Brand Brand { get; set; }

        //Bir ürünün category ile çoka çok ilişki de olması gerekli !
        public ICollection<Category> Categories { get; set; }

    }
}
