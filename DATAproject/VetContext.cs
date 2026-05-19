using DATAproject.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATAproject
{
    public class VetContext:DbContext
    {
        public DbSet<Userr> Users { get; set; }
        public DbSet<Animal> Animals { get; set; }
        public DbSet<Breed> Breeds { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<EmployeeType> EmployeeTypes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder();
            builder.AddJsonFile("vetJSON.json");
            var config = builder.Build();
            string connectionstring = config.GetConnectionString("DefaultConnection");
            optionsBuilder.UseSqlServer(connectionstring);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pet>().HasOne(x=>x.Breed).WithMany(x=>x.Pets).HasForeignKey(x=>x.BreedId).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Breed>().HasOne(x => x.Animal).WithMany(x => x.Breeds).HasForeignKey(x => x.AnimalId).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Pet>().HasOne(x => x.Owner).WithMany(x => x.Pets).HasForeignKey(x => x.OwnerId).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Appointment>().HasOne(x => x.Pet).WithMany(x => x.Appointments).HasForeignKey(x => x.PetId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Appointment>().HasOne(x => x.Employee).WithMany(x => x.EmployeeAppointments).HasForeignKey(x => x.EmployeeId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Appointment>().HasOne(x => x.Service).WithMany(x => x.Appointments).HasForeignKey(x => x.ServiceId).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Userr>().HasOne(x => x.EmployeeType).WithMany(x => x.Users).HasForeignKey(x => x.EmployeeTypeId).OnDelete(DeleteBehavior.Cascade);

        }
    }
}
