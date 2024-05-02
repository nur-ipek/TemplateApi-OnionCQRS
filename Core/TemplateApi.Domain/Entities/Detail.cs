﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateApi.Domain.Common;

namespace TemplateApi.Domain.Entities
{
    public class Detail: EntityBase
    {
        public Detail()
        {
                
        }
        public Detail(string title, string description, int categoryId)
        {
            Title = title;
            Description = description;
            CategoryId = categoryId;
        }
        public required string Title { get; set; }
        public required string Description { get; set; }
        public required int CategoryId { get; set; }
        public Category Category { get; set; } // 1'e çok ilişkiii !!!
    }
}
