using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Facade facade = new Facade();
            facade.KrediKullan(new Musteri { Ad = "Ahmet", MusteriNo = 125123, TcNo = "11152152352" },1000);
        }
    }
}
