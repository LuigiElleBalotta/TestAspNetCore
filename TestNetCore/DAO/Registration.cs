using TestNetCore.Models.DB;

namespace TestNetCore.DAO
{
    public static class Registration
    {
        public static bool InsertUtente( BaseDAO dao, Utente utente )
        {
            return dao.DB.Insert( utente );
        }
    }
}
