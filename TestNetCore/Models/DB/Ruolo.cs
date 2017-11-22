using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
