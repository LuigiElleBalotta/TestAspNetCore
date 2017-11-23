using Lappa.ORM.Constants;
using TestNetCore.DAO;
using TestNetCore.Models.DB;

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

        public void UpdateGenres( string content, int userID )
        {
            if( dao.Connected ) {
                Users.UpdateGenres( dao, content, userID );
            }
        }

        public void UpdateArtists( string content, int userID )
        {
            if( dao.Connected ) {
                Users.UpdateArtists( dao, content, userID );
            }
        }

        public void UpdateSetup( string content, int userID )
        {
            if( dao.Connected ) {
                Users.UpdateSetup( dao, content, userID );
            }
        }

        public void UpdateCovers( string content, int userID )
        {
            if( dao.Connected ) {
                Users.UpdateCovers( dao, content, userID );
            }
        }

        public ProfiloStrumento[] GetStrumentiCollegati( int idUtente )
        {
            ProfiloStrumento[] profiloStrumenti = null;
            if( dao.Connected ) {
                profiloStrumenti = Users.GetStrumentiCollegati( dao, idUtente );
            }
            return profiloStrumenti;
        }

        public void UpdatePlayedInstruments( int[] strumentiSelezionati, int utenteId )
        {
            if( dao.Connected ) {
                Users.DeletePlayedInstrumentsForUser( dao, utenteId );
                Users.InsertPlayedInstrumentsForUser( dao, strumentiSelezionati, utenteId );
            }
        }
    }
}
