﻿using MySql.Data.MySqlClient;

namespace TestNetCore.Models.DB
{
    public class DBContext
    {
		public static string ConnectionString { get; set; }  
  
		public DBContext(string connectionString)  
		{  
			ConnectionString = connectionString;  
		}  
  
		public MySqlConnection GetConnection()  
		{  
			return new MySqlConnection(ConnectionString);  
		}  
    }
}
