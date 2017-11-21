using Lappa.ORM.Constants;
using TestNetCore.DAO;
using TestNetCore.Models.DB;
using TestNetCore.Models.Registration;

namespace TestNetCore.BO
{
    public class Registration
    {
		private BaseDAO dao = new BaseDAO( DatabaseType.MySql );

		public bool DoRegistration( RegisterViewModel obj )
		{
			if( dao.Connected ) {
				Utente ut = new Utente
							{
								Password = obj.Password,
								Email = obj.Email,
								FirstName = obj.FirstName,
								LastName = obj.LastName
							};

				return DAO.Registration.InsertUtente( dao, ut );
			}
			return false;
		}
    }
}
