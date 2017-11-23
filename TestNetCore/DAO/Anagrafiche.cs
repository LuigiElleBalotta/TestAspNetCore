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

        public static void DeleteInstrument( BaseDAO dao, int[] ids )
        {
            foreach( int id in ids )
                dao.DB.Delete<Strumento>( x => x.ID == id );
        }
    }
}
