using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIP.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        public string FirstName { get; set; } = String.Empty;
        public string LastName { get; set; } = String.Empty;
        public DateTime BirthDate { get; set; } = DateTime.Today;
        public string Account { get; set; } = String.Empty;
        public string Bank { get; set; } = String.Empty;
        public bool CollectionPayment { get; set; }
        public string Note { get; set; } = String.Empty;
    }
}
