﻿using CheeseMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace CheeseMVC.Data
{
    public class CheeseDbContext : DbContext
    {
        public DbSet<Cheese> Cheeses { get; set; }
        public DbSet<CheeseCategory> Categories { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<CheeseMenu> CheeseMenus { get; set; }

        public CheeseDbContext(DbContextOptions<CheeseDbContext> options) 
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CheeseMenu>()
                .HasKey(c => new { c.CheeseID, c.MenuID });
        }
    }
	
	//public class CheeseDbContext : DbContext
    //{
    //    public DbSet<Cheese> Cheeses { get; set; }
    //    
    //    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            // Specify the path of the database here
    //        optionsBuilder.UseSqlite("Data Source=./CheeseMVC.sqlite");
    //    }

    //    public CheeseDbContext(DbContextOptions<CheeseDbContext> options) 
    //        : base(options)
    //    { }

    //}
}

