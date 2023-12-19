using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handball_Shopv1.Shared
{
    public class Statistics
    {
        public int ID { get; set; }
        public int Visits { get; set; }
        public DateTime? LastUserVisit { get; set; }
    }
}
