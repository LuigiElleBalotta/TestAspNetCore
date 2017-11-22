using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestNetCore.Constants;
using TestNetCore.Models.DB;
using TestNetCore.Models.User;

namespace TestNetCore.Models.Login
{
    public class LoginResponse
    {
        public Misc.LoginStatus Status { get; set; }
        public UserModel Utente { get; set; }
    }
}
