﻿using Microsoft.EntityFrameworkCore;
using UnitTest_Mock.Models;

namespace UnitTest_Mock.Data
{
    public class ApiDbContext : DbContext
    {
        public virtual DbSet<Employee> Employee { get; set; }

        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {

        }
    }
}
