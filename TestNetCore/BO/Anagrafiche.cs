using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lappa.ORM.Constants;
using TestNetCore.DAO;
using TestNetCore.Models.DB;

namespace TestNetCore.BO
{
    public class Anagrafiche
    {
        private BaseDAO dao = new BaseDAO( DatabaseType.MySql );

        public Strumento[] GetListaStrumenti()
        {
            Strumento[] ListaStrumenti = null;
            if( dao.Connected ) {
                ListaStrumenti = dao.DB.SelectArray<Strumento>().OrderBy( x => x.ID ).ToArray();
            }
            return ListaStrumenti;
        }

        public void AddInstrument( string descrizione )
        {
            if( dao.Connected ) {
                DAO.Anagrafiche.AddInstrument( dao, descrizione );
            }
        }

        public void UpdateInstrument( string descrizione, int id )
        {
            if( dao.Connected ) {
                DAO.Anagrafiche.UpdateInstrument( dao, descrizione, id );
            }
        }
    }
}
