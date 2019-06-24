using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class InterbaseFactory : DatabaseFactory
    {
        public override Command createCommand()
        {
            return new InterbaseCommand();
        }

        public override Connection createConnection()
        {
            return new InterbaseConnection();
        }
    }
}
