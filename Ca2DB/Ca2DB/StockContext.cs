﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ca2DB
{
    class StockContext: DbContext
    {
        public DbSet<Customer>Customers { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
