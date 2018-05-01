using LiftoffRestaurant.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LiftoffRestaurant.Data
{
    public class FoodDbContext : DbContext
    {
        public DbSet<Food> Foods { get; set; }
        public DbSet<FoodCategory> Categories { get; set; }

        public FoodDbContext(DbContextOptions<FoodDbContext> options)
            : base(options)
        { }
    }
}
