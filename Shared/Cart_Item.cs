using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handball_Shopv1.Shared
{
    public class Cart_Item // Data Transfer Object
    {
        public int ProductId { get; set; }
        public int AdditionId { get; set; }
        public string Product_Title { get; set; }
        public string Addition_Name { get; set; }
        public double? Price { get; set; }
        public string Product_Image { get; set; }
        public string SelectedColor { get; set; }
    }
}
