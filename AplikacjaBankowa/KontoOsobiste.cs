using System;
using System.Collections.Generic;
using System.Text;

namespace AplikacjaBankowa
{
    class KontoOsobiste : Konto, IOsobista
    {
        public override double Wplac()
        {
            return 1.0;
        }

        public override double Wyplac()
        {
            return 1.0;
        }

        public double KontrolaWyplaty()
        {
            throw new NotImplementedException();
        }

    }
}
