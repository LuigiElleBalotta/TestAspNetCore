using TestNetCore.Models.DB;

namespace TestNetCore.Models.User
{
    public class ProfiloModel
    {
        public Utente Utente { get; set; }
        public Profilo Profilo { get; set; }
        public Strumento[] Strumenti { get; set; }
        public int[] StrumentiCollegati { get; set; }
    }
}
