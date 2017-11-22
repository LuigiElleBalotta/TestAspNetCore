using Lappa.ORM;

namespace TestNetCore.Models.DB
{
	[DBTable(Pluralize = false)]
    public class Utente : Entity
    {
		public int ID { get; set; }
		public string Email { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
        public string Password { get; set; }
    }
}
