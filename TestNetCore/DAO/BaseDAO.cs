using Lappa.ORM;
using Lappa.ORM.Constants;
using TestNetCore.Models.DB;

namespace TestNetCore.DAO
{
    public class BaseDAO
    {
		public Database DB = new Database();
		public bool Connected { get; set; }

		public BaseDAO( DatabaseType dbtype )
		{
			switch( dbtype ) {
				case DatabaseType.MySql:
				break;
				case DatabaseType.MSSql:
					break;
			}

			if( DB.Initialize( DBContext.ConnectionString, dbtype, false )) {
				Connected = true;
			} else {
				Connected = false;
			}
		}
    }
}
