using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern_Ornek_2
{
    
    public class SekilFactory
    {
        public enum enSekilTur
        {
            enKare,
            enCember,
            enDiktordgen
        }
        public ISekil GetSekil(enSekilTur sekilTur)
        {
            switch (sekilTur)
            {
                case enSekilTur.enKare:
                    return new Kare();
                case enSekilTur.enCember:
                    return new Cember();
                case enSekilTur.enDiktordgen:
                    return new Dikdortgen();
                default:
                    return null;
            }
        }
    }
}
