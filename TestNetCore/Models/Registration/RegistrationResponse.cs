using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestNetCore.Models.DB;

namespace TestNetCore.Models.Registration
{
    public class RegistrationResponse
    {
        public bool Inserted { get; set; }
        public Utente Utente { get; set; }
    }
}
