﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TestWeb.Models
{
    public class DataContext:DbContext
    {
        public DataContext() : base("freeaspconnection") { }

        public DbSet<User> Users { get; set; }
    }
}