using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class DB2Factory : DatabaseFactory
    {
        public override Command createCommand()
        {
            return new DB2Command();
        }

        public override Connection createConnection()
        {
            return new DB2Connection();
        }
    }
}
