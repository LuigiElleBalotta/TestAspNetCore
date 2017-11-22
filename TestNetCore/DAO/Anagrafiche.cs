using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestNetCore.Models.DB;

namespace TestNetCore.DAO
{
    public class Anagrafiche
    {
        public static void UpdateInstrument( BaseDAO dao, string descrizione, int id )
        {
            dao.DB.Update<Strumento>( x => x.ID == id, x => x.Descrizione.Set( descrizione ));
        }

        public static void AddInstrument( BaseDAO dao, string descrizione )
        {
            dao.DB.Insert( new Strumento{ Descrizione = descrizione});
        }
    }
}
