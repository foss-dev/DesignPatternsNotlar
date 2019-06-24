using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern
{
    public class Facade
    {
        private Banka _banka;
        private MerkezBanka merkezBanka;
        private Kredi _kredi;

        public Facade()
        {
            _banka = new Banka();
            merkezBanka = new MerkezBanka();
            _kredi = new Kredi();
        }

        public void KrediKullan(Musteri m,decimal talepEdilenMiktar)
        {
            if (!merkezBanka.KaraListeKontrol(m.TcNo) && _kredi.KrediKullanmaDurumu(m))
            {
                _banka.KrediyiKullan(m, talepEdilenMiktar);
                Console.WriteLine("Kredi kullanıldı");
            }
        }
    }
}
