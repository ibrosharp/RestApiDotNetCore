using Commander.Models;  
using Microsoft.EntityFrameworkCore;  
using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Threading.Tasks;  
  
namespace Commander.Data  
{  
    public class CommanderContext : DbContext  
    {  

        public DbSet<Command> Commands { get; set; }  
  
        public CommanderContext(DbContextOptions<CommanderContext> options) : base(options)  
        {   
        }  
  
        protected override void OnModelCreating(ModelBuilder modelBuilder)  
        {  
            // Use Fluent API to configure  
  
            // Map entities to tables  
            modelBuilder.Entity<Command>().ToTable("commands");  
  
            // Configure Primary Keys  
            modelBuilder.Entity<Command>().HasKey(c => c.Id).HasName("id");  
        
  
            // Configure columns  
            modelBuilder.Entity<Command>().Property(c => c.Id).HasColumnType("int").UseMySqlIdentityColumn().IsRequired();  
            modelBuilder.Entity<Command>().Property(c => c.Line).HasColumnType("varchar(191)").IsRequired();  
            modelBuilder.Entity<Command>().Property(c => c.Platform).HasColumnType("varchar(191)").IsRequired();  
            modelBuilder.Entity<Command>().Property(c => c.HowTo).HasColumnType("text").IsRequired(false);  
  
              
  
        }  
    }  
}  