using ArtSite.Server.Data;
using ArtSite.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtSite.Server.Repository
{
    public class ArtworkRepository
    {
        private ArtDbContext _context;

        public ArtworkRepository(ArtDbContext context)
        {
            _context = context;
        }

        public List<Artwork> GetAll()
        {
            return _context.Artwork.ToList();
        }

    }
}
