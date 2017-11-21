using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lappa.ORM.Constants;
using TestNetCore.Constants;
using TestNetCore.DAO;
using TestNetCore.Models.DB;
using TestNetCore.Models.Login;

namespace TestNetCore.BO
{
    public class Login
    {
        private BaseDAO dao = new BaseDAO( DatabaseType.MySql );

        public LoginResponse CheckLogin( LoginModel form )
        {
            if( dao.Connected ) {

                Utente ret = DAO.Login.GetUtente( dao, form.Email, form.Password );

                LoginResponse response = new LoginResponse
                                                {
                                                    Status = ret != null ? Misc.LoginStatus.OK : Misc.LoginStatus.Failed,
                                                    Utente = ret
                                                };

                return response;
            }
            return new LoginResponse{ Status = Misc.LoginStatus.Failed };
        }
    }
}
