using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Micro_Finance.Class
{
    public class ConnectionEnity
    {
        public string ip, un, pw, db, port, driver, spname;
        public string[] @params;
        public ConnectionEnity(string ip, string un, string pw, string db, string port, string driver, string spname, string[] @params)
        {
            this.ip = ip;
            this.un = un;
            this.pw = pw;
            this.db = db;
            this.port = port;
            this.driver = driver;
            this.spname = spname;
            this.@params = @params;
        }
    }
}
