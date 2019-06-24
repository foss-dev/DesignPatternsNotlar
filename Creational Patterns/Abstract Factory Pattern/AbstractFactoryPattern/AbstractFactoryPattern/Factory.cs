using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class Factory
    {
        private DatabaseFactory databaseFactory;
        private Connection connection;
        private Command command;
        public Factory(DatabaseFactory databaseFactory)
        {
            this.databaseFactory = databaseFactory;
            this.connection = databaseFactory.createConnection();
            this.command = databaseFactory.createCommand();
        }

        public void Start()
        {
            connection.Connect();
            if (connection.State == "Baglantı Durumu")
                command.Execute("Select");
        }
    }
}
