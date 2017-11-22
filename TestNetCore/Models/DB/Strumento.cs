using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
