using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RistoranteMVC.Models
{
    public class RistoranteMVCDbContext : DbContext
    {
        public RistoranteMVCDbContext(DbContextOptions<RistoranteMVCDbContext> options) : base(options)
        {
        }

        public DbSet<Dish> Dishes { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Coupon> Coupons { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}
