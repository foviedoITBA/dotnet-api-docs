﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Odbc;

namespace Classic_WebData_OdbcConnection.CloseCS
{
	class Program
	{
		// <Snippet1>
		private static void CreateOdbcConnection(string connectionString)
		{
            using (OdbcConnection connection = new OdbcConnection(connectionString))
            {
                connection.Open();
                Console.WriteLine("ServerVersion: " + connection.ServerVersion
                    + "\nDatabase: " + connection.Database);

                // The connection is automatically closed at
                // the end of the Using block.
            }
        }
		// </Snippet1>
	}
}
