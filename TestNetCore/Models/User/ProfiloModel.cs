using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestNetCore.Models.DB;

namespace TestNetCore.Models.User
{
    public class ProfiloModel
    {
        public Utente Utente { get; set; }
        public Profilo Profilo { get; set; }
    }
}
