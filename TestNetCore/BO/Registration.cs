using Lappa.ORM.Constants;
using TestNetCore.DAO;
using TestNetCore.Models.DB;
using TestNetCore.Models.Registration;

namespace TestNetCore.BO
{
    public class Registration
    {
		private BaseDAO dao = new BaseDAO( DatabaseType.MySql );

		public RegistrationResponse DoRegistration( RegisterViewModel obj )
		{
			if( dao.Connected ) {
				Utente ut = new Utente
							{
								Password = obj.Password,
								Email = obj.Email,
								FirstName = obj.FirstName,
								LastName = obj.LastName
							};

                bool ret = DAO.Registration.InsertUtente( dao, ut );

                ut.ID = DAO.Users.GetID( dao, ut.Email, ut.Password );

                if( ret ) {
                    //Creates a new profile connected to user
                    Profilo profilo = new Profilo{ IDUtente = ut.ID };

                    DAO.Registration.InsertProfilo( dao, profilo );
                }

                RegistrationResponse response = new RegistrationResponse
                                                {
                                                    Inserted = ret,
                                                    Utente = ut
                                                };

				return response;
			}
			return new RegistrationResponse{ Inserted = false };
		}
    }
}
