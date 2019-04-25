using System;
using System.Collections.Generic;
using System.Text;

namespace AplikacjaBankowa
{
    class KontoLokata : Konto, IZysk
    {
        public double stopaProcentowa = 2.5;

        public override double Wplac()
        {
            return 1;
        }

        public override double Wyplac()
        {
            return 1;
        }

        public double ObliczZysk()
        {
            return 100;
        }


    }
}
