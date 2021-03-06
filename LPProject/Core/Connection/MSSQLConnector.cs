﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace LPProject.Core.Connection
{
    public class MSSQLConnector
    {
        public SqlConnection _connection;
        public static string ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionIris"].ConnectionString;
        private static readonly MSSQLConnector _instance;
        public static MSSQLConnector Instance
        {
            get
            {
                return _instance;
            }
        }

        

        static MSSQLConnector()
        {
            _instance = new MSSQLConnector();
        }
        private MSSQLConnector()
        {
            _connection = new SqlConnection(ConnectionString);
        }

    }
}
