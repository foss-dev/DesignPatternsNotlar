using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class InterbaseConnection : Connection
    {
        public override string State
        {
            get { return "Baglanti Durumu"; }
        }


        public override bool Connect()
        {
            Console.WriteLine("Interbase Baglaantısı Acılacak");
            return true;
        }

        public override bool DisConnect()
        {
            Console.WriteLine("Interbase Baglaantısı Acılacak");
            return true;
        }
    }
}
