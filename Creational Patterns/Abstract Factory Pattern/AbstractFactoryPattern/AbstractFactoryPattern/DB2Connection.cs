using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class DB2Connection : Connection
    {
        public override string State
        {
            get { return "Baglanti Durumu"; }
        }

        public override bool Connect()
        {
            Console.WriteLine("DB2 Baglaantısı Acılacak");
            return true;
        }

        public override bool DisConnect()
        {
            Console.WriteLine("DB2 Baglantısı Kapatılacak");
            return true;
        }
    }
}
