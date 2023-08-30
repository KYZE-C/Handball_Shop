using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Handball_Shopv1.Shared
{
    public class Variants_Product
    {
        [JsonIgnore]
        public Product Product { get; set; }
        public int ProductId { get; set; }
        public Platform Addition { get; set; }
        public int AdditionId { get; set; }
        public double? Price { get; set; } = null;
        public double? OriginalPrice { get; set; } = null;
    }
}
