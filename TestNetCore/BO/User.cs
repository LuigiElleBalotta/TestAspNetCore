using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lappa.ORM.Constants;
using TestNetCore.DAO;
using TestNetCore.Models.DB;
using TestNetCore.Models.Registration;

namespace TestNetCore.BO
{
    public class User
    {
        private BaseDAO dao = new BaseDAO( DatabaseType.MySql );

        public Profilo GetProfilo( int userID )
        {
            Profilo profilo = null;
            if( dao.Connected ) {
                profilo = Users.GetProfilo( dao, userID );
            }
            return profilo;
        }

        public void UpdateBiography( string content, int userID )
        {
            if( dao.Connected ) {
                Users.UpdateBiography( dao, content, userID );
            }
        }
    }
}
