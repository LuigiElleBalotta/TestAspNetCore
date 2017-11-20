using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Protocols;

namespace TestNetCore.Models.MySQL
{
    public class ConnectionObject
    {
		public string Host { get; set; }
		public string UserName { get; set; }
		public string Password { get; set; }
		public string Database { get; set; }
    }
}
