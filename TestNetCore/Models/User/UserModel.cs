using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestNetCore.Constants;
using TestNetCore.Models.DB;

namespace TestNetCore.Models.User
{
    public class UserModel
    {
        public Utente Utente { get; set; }
        public Misc.Roles Ruolo { get; set; }
    }
}
