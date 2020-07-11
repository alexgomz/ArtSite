using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArtSite.Client.Pages;
using ArtSite.Shared.Models;
using ArtSite.Server.Data;
using ArtSite.Server.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ArtSite.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ArtworkController : ControllerBase
    {
        private readonly ArtDbContext _context;

        public ArtworkController(ArtDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public List<Artwork> ShowAll()
        {
            return _context.Artwork.ToList();
        }

    }
}
