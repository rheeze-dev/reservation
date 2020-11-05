using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Configuration;

namespace AsinTransientAndApartment.Models
{
    public class ReservationDBContext : DbContext
    {
        public ReservationDBContext( DbContextOptions<ReservationDBContext> options)
            : base(options)
        {

        }
        public DbSet<User> users { get; set; }
        public DbSet<Guest> guests { get; set; }
        public DbSet<Reservation> reservations { get; set; }
        public DbSet<Room> rooms { get; set; }
        public DbSet<Status> statuses { get; set; }
        public DbSet<Type> types { get; set; }
        public DbSet<UserRole> userRoles { get; set; }
        public DbSet<Reserve> Reserve { get; set; }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(ConfigurationManager.connectionString["ReservationDB"].ConnectionString);
        //}
    }
}
