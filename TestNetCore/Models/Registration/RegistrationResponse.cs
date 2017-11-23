using TestNetCore.Models.DB;

namespace TestNetCore.Models.Registration
{
    public class RegistrationResponse
    {
        public bool Inserted { get; set; }
        public Utente Utente { get; set; }
    }
}
