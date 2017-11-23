using Lappa.ORM;

namespace TestNetCore.Models.DB
{
    [DBTable(Pluralize = false)]
    public class UtenteRuolo : Entity
    {
        public int IDUtente { get; set; }
        public int IDRuolo { get; set; }
    }
}
