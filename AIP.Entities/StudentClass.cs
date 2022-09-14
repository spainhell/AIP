using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIP.Entities
{
    internal class StudentClass
    {
        public int IdZak { get; set; }
        public DateTime DateSince { get; set; }
        public DateTime DateTo { get; set; }
        public int IdSchoolClass { get; set; }
        public string VarSymbol { get; set; }
    }
}
