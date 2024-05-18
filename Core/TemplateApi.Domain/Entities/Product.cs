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
        public Product()
        {
                
        }
        public Product(string Title, string Description, int BrandId, decimal Price,
            decimal Discount)
        {
            this.Title = Title;
            this.Description = Description;
            this.BrandId = BrandId;
            this.Price = Price;
            this.Discount = Discount;
        }
        public string Title { get; set; }
        public string Description { get; set; }
        public int BrandId { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public Brand Brand { get; set; }

        //Bir ürünün category ile çoka çok ilişki de olması gerekli !
        public ICollection<ProductCategory> ProductCategories { get; set; }

    }
}
