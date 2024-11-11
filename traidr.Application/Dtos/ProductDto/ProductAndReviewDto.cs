﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using traidr.Domain.Models;

namespace traidr.Application.Dtos.ProductDto
{
    public class ProductAndReviewDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public ICollection<string> Images { get; set; }
        public List<Review> Reviews { get; set; }
    }
}