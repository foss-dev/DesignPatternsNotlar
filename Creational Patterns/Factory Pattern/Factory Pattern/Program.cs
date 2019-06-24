using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creator creator = new Creator();
            //Screen screenWin = creator.ScreenFactory(ScreenModel.Windows);
            //Screen screenWeb = creator.ScreenFactory(ScreenModel.Web);
            //Screen screenMobile = creator.ScreenFactory(ScreenModel.Mobile);

            //screenWin.Draw();
            //screenWeb.Draw();
            //screenMobile.Draw();

            Creator2[] creators = {
                new WinScreenCreator(),
                new MobileScreenCreator(),
                new WebScreenCreator()
            };

            foreach (Creator2 creator in creators)
            {
                Screen screen = creator.ScreenFactory();
                screen.Draw();
            }
        }
    }
}
