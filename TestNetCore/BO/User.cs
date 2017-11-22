﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lappa.ORM.Constants;
using TestNetCore.DAO;
using TestNetCore.Models.DB;
using TestNetCore.Models.Registration;

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
    }
}
