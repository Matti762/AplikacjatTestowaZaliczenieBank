using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AplikacjaBankowa
{
    class Bank
    {
        //private List<Konto> listaKont;
        private ArrayList listaKont2;

        public Bank()
        {
            //listaKont.Add(new KontoLokata() { saldo = -10.25,  nrKonta = "12345" });
            //listaKont.Add(new KontoLokata() { saldo = 30.81,   nrKonta = "12345-12364" });
            //listaKont.Add(new KontoLokata() { saldo = 1120.78, nrKonta = "879243-25148-31515" });

            listaKont2.Add(new KontoLokata() { saldo = -10.25, nrKonta = "12345" });
            listaKont2.Add(new KontoLokata() { saldo = 30.81, nrKonta = "12345-12364" });
            listaKont2.Add(new KontoLokata() { saldo = 1120.78, nrKonta = "879243-25148-31515" });
        }

        public ArrayList GetAccounts(ArrayList zbiorKont, string konto)
        {


            return [1, 1];
        }


    }
}



