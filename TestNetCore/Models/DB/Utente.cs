using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lappa.ORM;

namespace TestNetCore.Models.DB
{
	[DBTable(Pluralize = false)]
    public class Utente : Entity
    {
		public int ID { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
    }
}
