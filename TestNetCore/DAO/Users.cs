using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestNetCore.Models.DB;

namespace TestNetCore.DAO
{
    public static class Users
    {
        public static int GetID( BaseDAO dao, string email, string password )
        {
            return dao.DB.Single<Utente>( x => x.Email == email && x.Password == password  ).ID;
        }
    }
}
