using System;
using System.Collections.Generic;
using System.Text;

namespace ArtSite.Shared.Models
{
    public class Artwork
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Section { get; set; }
        public bool Show { get; set; }

    }
}
