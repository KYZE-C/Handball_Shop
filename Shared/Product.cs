using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handball_Shopv1.Shared
{
    public class Product
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; } = "https://via.placeholder.com/400x400";
        public int? Quality { get; set; } = null;
        public bool IsDeleted { get; set; }
        public bool IsPublic { get; set; }
        public List<Variants_Product> Variants { get; set; } = new List<Variants_Product>();
        public int CategoryId { get; set; }
        public DateTime? DateCreated { get; set; } = DateTime.Now;
        public DateTime? DateUpdated { get; set; }
        public string? SizeOfPreview { get; set; } = null;
        public double? Demensions { get; set; } = null;
        public string? ColorOfPreview { get; set; }
    }
}
