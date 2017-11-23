using TestNetCore.Constants;
using TestNetCore.Models.DB;

namespace TestNetCore.DAO
{
    public static class Login
    {
        public static Utente GetUtente( BaseDAO dao, string Email, string Password )
        {
            return dao.DB.Single<Utente>( x => x.Email == Email && x.Password == Password );
        }

        public static Misc.Roles GetRuoloUtente( BaseDAO dao, int utenteId )
        {
            return (Misc.Roles)dao.DB.Single<UtenteRuolo>( x => x.IDUtente == utenteId ).IDRuolo;
        }
    }
}
