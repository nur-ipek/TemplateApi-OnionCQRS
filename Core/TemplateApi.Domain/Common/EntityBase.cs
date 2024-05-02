using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateApi.Domain.Common
{
    public class EntityBase: IEntityBase
    {
        //Her bir class'ı oluştururken buradan türeteceğiz.
        //Default olarak kullanacağımız alanlar.
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; } = false;
    }
}
