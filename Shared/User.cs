using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handball_Shopv1.Shared
{
    public class User
    {
        public int Id { get; set; }
        public string? Email { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string? FirstName { get; set; }
        public string? Surname { get; set; }

    }
}
