using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateApi.Application.Bases;
using TemplateApi.Application.Features.Products.Exceptions;
using TemplateApi.Domain.Entities;

namespace TemplateApi.Application.Features.Products.Rules
{
    public class ProductRules: BaseRules
    {
        public Task ProductTitleMustNotBeSame(IList<Product> products, string requestTitle)
        { 
            if(products.Any(x=> x.Title == requestTitle)) throw new ProductTitleMustNotBeSameException();
            return Task.CompletedTask;
        }
    }
}
