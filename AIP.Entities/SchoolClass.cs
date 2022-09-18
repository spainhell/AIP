using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIP.Entities
{
    public class SchoolClass
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Teachers { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int Tax { get; set; }
        public string Note { get; set; }
    }
}
