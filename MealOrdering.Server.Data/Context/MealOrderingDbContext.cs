using MealOrdering.Server.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MealOrdering.Server.Data.Context
{
    public class MealOrderingDbContext:DbContext
    {
        
        public MealOrderingDbContext(DbContextOptions<MealOrderingDbContext> options) : base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(i => i.Id);                                         
                entity.Property(I => I.Id).UseIdentityColumn();
            });


            modelBuilder.Entity<Supplier>(entity =>
            {               
                entity.HasKey(I => I.Id);
                entity.Property(I => I.Id).UseIdentityColumn();

            });


            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(e => e.Id);              
                entity.Property(I => I.Id).UseIdentityColumn();


                entity.HasOne(d => d.CreatedUser)
                   .WithMany(p => p.Orders)
                   .HasForeignKey(d => d.CreatedUserId);                  
                 

                entity.HasOne(d => d.Supplier)
                   .WithMany(p => p.Orders)
                   .HasForeignKey(d => d.SupplierId);              
                  

            });

            modelBuilder.Entity<OrderItem>(entity =>
            { 

                entity.HasKey(I => I.Id);

                entity.Property(I => I.Id).UseIdentityColumn();


                entity.HasOne(d => d.Order)
                   .WithMany(p => p.OrderItems)
                   .HasForeignKey(d => d.OrderId).OnDelete(DeleteBehavior.NoAction);

                entity.HasOne(d => d.CreatedUser)
                   .WithMany(p => p.CreatedOrderItems)
                   .HasForeignKey(d => d.CreatedUserId).OnDelete(DeleteBehavior.NoAction);


            });


            base.OnModelCreating(modelBuilder); 
        }

        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<OrderItem> OrderItem { get; set; }
        public virtual DbSet<Supplier> Supplier { get; set; }
    }
}
