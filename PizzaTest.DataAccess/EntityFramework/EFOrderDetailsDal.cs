﻿using PizzaTest.DataAccess.Abstract;
using PizzaTest.DataAccess.Context;
using PizzaTest.DataAccess.Repositories;
using PizzaTest.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaTest.DataAccess.EntityFramework
{
    public class EFOrderDetailsDal : GenericRepository<OrderDetails>, IOrderDetailDal
    {
        public EFOrderDetailsDal(AppDbContext context) : base(context)
        {
        }
    }
}
