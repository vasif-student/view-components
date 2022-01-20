using Hotel_App.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_App.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Banner> Banners { get; set; }
        public DbSet<BannerImage> BannerImages { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Swiper> Swipers { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Slider> Sliders { get; set; }
    }
}
