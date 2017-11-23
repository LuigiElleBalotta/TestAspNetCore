using Lappa.ORM.Constants;
using TestNetCore.Constants;
using TestNetCore.DAO;
using TestNetCore.Models.Login;
using TestNetCore.Models.User;

namespace TestNetCore.BO
{
    public class Login
    {
        private BaseDAO dao = new BaseDAO( DatabaseType.MySql );

        public LoginResponse CheckLogin( LoginModel form )
        {
            if( dao.Connected ) {

                UserModel ret = new UserModel();
                
                ret.Utente = DAO.Login.GetUtente( dao, form.Email, form.Password );
                ret.Ruolo = DAO.Login.GetRuoloUtente( dao, ret.Utente.ID );

                LoginResponse response = new LoginResponse
                                                {
                                                    Status = ret.Utente.ID > 0 ? Misc.LoginStatus.OK : Misc.LoginStatus.Failed,
                                                    Utente = ret
                                                };

                return response;
            }
            return new LoginResponse{ Status = Misc.LoginStatus.Failed };
        }
    }
}
