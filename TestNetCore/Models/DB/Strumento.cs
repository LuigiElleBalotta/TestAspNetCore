using Lappa.ORM;

namespace TestNetCore.Models.DB
{
    [DBTable(Pluralize = false, Name = "Strumenti")]
    public class Strumento : Entity
    {
        public int ID { get; set; }
        public string Descrizione { get; set; }
    }
}
