using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public abstract class DatabaseFactory
    {
        public abstract Connection createConnection();
        public abstract Command createCommand();
    }
}
