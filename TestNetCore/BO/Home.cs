using System.Collections.Generic;
using Lappa.ORM.Constants;
using TestNetCore.DAO;
using TestNetCore.Models.DB;

namespace TestNetCore.BO
{
    public class Home
    {
        private BaseDAO dao = new BaseDAO( DatabaseType.MySql );

        public Utente[] GetListaUtenti()
        {
            Utente[] ListaUtenti = null;
            if( dao.Connected ) {
                ListaUtenti = dao.DB.SelectArray<Utente>();
            }
            return ListaUtenti;
        }
    }
}
