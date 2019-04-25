using System;
using System.Collections.Generic;
using System.Text;

namespace AplikacjaBankowa
{
    abstract class Konto
    {
        public string nrKonta { get; set; }
        public double saldo { get; set; }

        abstract public double Wplac();
        abstract public double Wyplac();
    }
}