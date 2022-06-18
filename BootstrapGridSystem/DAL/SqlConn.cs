using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BootstrapGridSystem.DAL
{
    public class SqlConn
    {
        private string _connectionString = @"Server=BLGAE;Database=MvcWebSite;Trusted_Connection=True;";
        public string ConnectionString { get { return _connectionString; } }
    }
}