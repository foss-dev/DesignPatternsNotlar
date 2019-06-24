using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    public abstract class Screen //Product Sınıfı
    {
        public abstract void Draw();
    }


    //Ana product sınıfından kalıtım alan alt Productlarımız
    public class WindowsScreen : Screen
    {
        public override void Draw()
        {
            Console.WriteLine("Windows Ekranı");
        }
    }

    public class WebScreen : Screen
    {
        public override void Draw()
        {
            Console.WriteLine("Web Ekranı");
        }
    }

    public class MobileScreen : Screen
    {
        public override void Draw()
        {
            Console.WriteLine("Mobil Ekranı");
        }
    }
}
