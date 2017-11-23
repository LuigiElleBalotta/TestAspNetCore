using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lappa.ORM;

namespace TestNetCore.Models.DB
{
    [DBTable( Pluralize = false, Name = "profilostrumenti")]
    public class ProfiloStrumento : Entity
    {
        public int IDProfilo { get; set; }
        public int IDStrumento { get; set; }
    }
}
