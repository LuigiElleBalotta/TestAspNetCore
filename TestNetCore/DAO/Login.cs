using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestNetCore.Models.DB;

namespace TestNetCore.DAO
{
    public static class Login
    {
        public static Utente GetUtente( BaseDAO dao, string Email, string Password )
        {
            return dao.DB.Single<Utente>( x => x.Email == Email && x.Password == Password );
        }
    }
}
