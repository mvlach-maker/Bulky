﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Bulky.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        public string Description { get; set; }
        public string ISBN { get; set; }
        [Required]
        [Display(Name ="List Price")]
        [Range(1,100)]
        public double ListPrice { get; set; }

        [Required]
        [Display(Name = "Price for 1-10")]
        [Range(1, 100)]
        public double Price { get; set; }

        [Required]
        [Display(Name = "Price for 10+")]
        [Range(1, 100)]
        public double Price10 { get; set; }

        [Required]
        [Display(Name = "Price for 50+")]
        [Range(1, 100)]
        public double Price50 { get; set; }

        public int CategoryId {  get; set; }
        [ForeignKey("CategoryId")]
        [ValidateNever]
        public Category Category { get; set; }
        [ValidateNever]
        public string ImageUrl { get; set; }
    }
}
