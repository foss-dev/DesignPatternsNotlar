using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    public enum ScreenModel
    {
        Windows,
        Web,
        Mobile
    }

    // Creator Sınıfı
    public class Creator
    {
        //Factory Methodu
        public Screen ScreenFactory(ScreenModel screenModel)
        {
            Screen screen = null;
            switch (screenModel)
            {
                case ScreenModel.Windows:
                    screen = new WindowsScreen();
                    break;
                case ScreenModel.Web:
                    screen = new WebScreen();
                    break;
                case ScreenModel.Mobile:
                    screen = new MobileScreen();
                    break;
                default:
                    break;
            }
            return screen;
        }
    }

    public abstract class Creator2
    {
        public abstract Screen ScreenFactory();
    }

    class WinScreenCreator : Creator2
    {
        public override Screen ScreenFactory()
        {
            return new WindowsScreen();
        }
    }

    class WebScreenCreator : Creator2
    {
        public override Screen ScreenFactory()
        {
            return new WebScreen();
        }
    }

    class MobileScreenCreator : Creator2
    {
        public override Screen ScreenFactory()
        {
            return new MobileScreen();
        }
    } 
}
