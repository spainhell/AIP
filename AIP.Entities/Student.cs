﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIP.Entities
{
    internal class Student
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Account { get; set; }
        public bool CollectionPayment { get; set; }
        public string Note { get; set; }
    }
}
