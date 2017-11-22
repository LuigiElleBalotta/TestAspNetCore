using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lappa.ORM;

namespace TestNetCore.Models.DB
{
    [DBTable( Pluralize = false, Name = "Profili")]
    public class Profilo : Entity
    {
        public int          IDUtente { get; set; }
        public string       Biografia { get; set; }
        public string       PlayedCovers { get; set; }
        public string       PersonalSetup { get; set; }
        public string       FavouriteArtists { get; set; }
        public string       FavouriteGenres { get; set; }
        public string       ProfileImage { get; set; }
    }
}
