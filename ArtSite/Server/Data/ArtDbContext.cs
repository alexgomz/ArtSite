using ArtSite.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtSite.Server.Data
{
    public class ArtDbContext : DbContext
    {
        public ArtDbContext(DbContextOptions<ArtDbContext> options) : base(options)
        {

        }

        public DbSet<Artwork> Artwork { get; set; }
    }
}
