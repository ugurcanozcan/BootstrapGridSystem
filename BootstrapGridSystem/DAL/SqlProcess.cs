using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BootstrapGridSystem.DAL
{
    public class SqlProcess
    {
        SqlConnection _conn;
        SqlCommand _cmd;
        readonly SqlConn _connectionString = new SqlConn();

        private SqlConnection SqlConnect()
        {
            _conn = new SqlConnection(_connectionString.ConnectionString);
            if (_conn.State != ConnectionState.Open)
            {
                _conn.Open();
            }
            return _conn;
        }
        private void SqlClosed()
        {
            if (_conn.State == ConnectionState.Open)
            {
                _conn.Close();
            }
        }

        public bool SetExecuteNonQuery(string cmdText)
        {
            try
            {
                _cmd = new SqlCommand(cmdText,this.SqlConnect());
                _cmd.ExecuteNonQuery();
                _cmd.Dispose();
                SqlClosed();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool SetExecuteNonQuery(string cmdText, params SqlParameter[] sqlParameters)
        {
            try
            {
                _cmd = new SqlCommand(cmdText, this.SqlConnect());
                _cmd.Parameters.AddRange(sqlParameters);
                _cmd.ExecuteReader();

                _cmd.Dispose();
                SqlClosed();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public DataTable SetExecuteReader(string cmdText)
        {
            _cmd = new SqlCommand(cmdText,this.SqlConnect());
            DataTable dt = new DataTable();
            dt.Load(_cmd.ExecuteReader());
            _cmd.Dispose();
            SqlClosed();
            return dt;
        }

    }
}