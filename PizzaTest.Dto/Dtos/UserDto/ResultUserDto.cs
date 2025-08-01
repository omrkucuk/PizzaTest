﻿using PizzaTest.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaTest.Dto.Dtos.UserDto
{
    public class ResultUserDto
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }

        public string? Email { get; set; }
        public string? Password { get; set; }
    }
}
