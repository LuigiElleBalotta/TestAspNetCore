using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestNetCore.Constants;
using TestNetCore.Models.DB;

namespace TestNetCore.Models.Login
{
    public class LoginResponse
    {
        public Misc.LoginStatus Status { get; set; }
        public Utente Utente { get; set; }
    }
}
