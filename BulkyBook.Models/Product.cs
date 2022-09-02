using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        [Required]
        public string ISBN { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        [Range(1,10000)]
        public double ListPrice { get; set; }
        [Required]
        [Range(1, 10000)]
        public double Price { get; set; } // Final price, buy 1 product
        [Required]
        [Range(1, 10000)]
        public double Price50 { get; set; } // Final price, buy 50 products, special price
        [Required]
        [Range(1, 10000)]
        public double Price100 { get; set; } // Final price, buy 100 product, special price
        public string ImageUrl { get; set; }
        [Required]
        [ForeignKey("CategoryId")] // this is not required when naming is set to tableId
        public int CategoryId { get; set; }
        public Category Category { get; set; } //EF automatically creates FK relation, because named of prop CategoryId
        [Required]
        [ForeignKey("CategoryId")]
        public int CoverTypeId { get; set; }
        public CoverType CoverType { get; set; } //EF automatically creates FK relation, because named of prop CoverTypeId
    }
}
