﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaTest.Entity.Concrete
{
    public class User
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }

        public string? Email { get; set; }
        public string? Password { get; set; }

        public ICollection<Order> Orders { get; set; }
        public ICollection<Address> Addresses { get; set; }

    }
}
