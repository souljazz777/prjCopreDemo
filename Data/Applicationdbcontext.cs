using System;
using System.Collections.Generic;
// 才能使用DbContext
using Microsoft.EntityFrameworkCore;
//才能知道Category是什麼
using prjCoreDemo.Models;

namespace prjCoreDemo.Data;

public class ApplicationDbContext : DbContext
{
    // basic config for connect the entity framework
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }
    // create dbset
    public DbSet<TCustomer> TCustomer { get; set; }
}