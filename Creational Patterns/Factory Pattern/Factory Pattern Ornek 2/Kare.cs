using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern_Ornek_2
{
    public class Kare : ISekil
    {
        public void Ciz()
        {
            Console.WriteLine("Kare Cizildi");
        }
    }
}
