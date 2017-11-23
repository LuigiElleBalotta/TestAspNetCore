using Lappa.ORM;

namespace TestNetCore.Models.DB
{
    [DBTable(Pluralize = false)]
    public class Ruolo : Entity
    {
        public int ID { get; set; }
        public string Descrizione { get; set; }
        public int ImportanceOrder { get; set; }
    }
}
