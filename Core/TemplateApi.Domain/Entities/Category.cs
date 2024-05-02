using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateApi.Domain.Common;

namespace TemplateApi.Domain.Entities
{
    public class Category: EntityBase
    {
        public Category() { }
        public Category(string name,int parentId, int priorty ) //nesneyi new'lediğimiz zaman hangi alanları verebiliyor olduğumuzu bu ctor sayesinde görmüş oluruz.
        {
            ParentId = parentId;
            Name = name;
            Priorty = priorty;

        }
        public required string Name { get; set; }
        public required int ParentId { get; set; }
        public required int Priorty { get; set; }
        public ICollection<Detail> Details { get; set; }
        public ICollection<Product> Products { get; set; } //Default convention
    }
}
