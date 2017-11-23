using TestNetCore.Models.DB;

namespace TestNetCore.DAO
{
    public static class Users
    {
        public static int GetID( BaseDAO dao, string email, string password )
        {
            return dao.DB.Single<Utente>( x => x.Email == email && x.Password == password  ).ID;
        }

        public static Profilo GetProfilo(BaseDAO dao, int userId )
        {
            return dao.DB.Single<Profilo>( profilo => profilo.IDUtente == userId );
        }

        public static void UpdateBiography( BaseDAO dao, string content, int userID )
        {
            dao.DB.Update<Profilo>( x => x.IDUtente == userID, x => x.Biografia.Set( content ));
        }

        public static void UpdateGenres( BaseDAO dao, string content, int userID )
        {
            dao.DB.Update<Profilo>( x => x.IDUtente == userID, x => x.FavouriteGenres.Set( content ));
        }

        public static void UpdateArtists( BaseDAO dao, string content, int userID )
        {
            dao.DB.Update<Profilo>( x => x.IDUtente == userID, x => x.FavouriteArtists.Set( content ));
        }

        public static void UpdateSetup( BaseDAO dao, string content, int userID )
        {
            dao.DB.Update<Profilo>( x => x.IDUtente == userID, x => x.PersonalSetup.Set( content ));
        }

        public static void UpdateCovers( BaseDAO dao, string content, int userID )
        {
            dao.DB.Update<Profilo>( x => x.IDUtente == userID, x => x.PlayedCovers.Set( content ));
        }
    }
}
