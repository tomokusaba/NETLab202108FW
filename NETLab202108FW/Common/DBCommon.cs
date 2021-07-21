using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace NETLab202108FW.Common
{
    public class DBCommon :IDisposable
    {
        public OracleConnection Con { get;  }

        public DBCommon()
        {
            string dbstring = "Data Source = (DESCRIPTION=(ADDRESS=(PROTOCOL=tcp)(HOST=host)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=servicename))); User Id = userid; Password = password";
            Con = new OracleConnection(dbstring);
            Con.Open();
        }

        public void Dispose()
        {
            if (Con != null)
            {
                if (Con.State == System.Data.ConnectionState.Open)
                {
                    Con.Close();
                }
            }
        }

        public static string GetString(OracleDataReader read, string target)
        {
            if (read.GetValue(read.GetOrdinal(target)).ToString() == "")
            {
                return "";
            }
            else
            {
                return read.GetString(read.GetOrdinal(target));
            }
        }
    }
}