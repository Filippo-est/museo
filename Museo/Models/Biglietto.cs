using System;
using System.Collections.Generic;
using System.Text;

namespace Museo.Models
{
    class Biglietto
    {
        int code;//codice del biglietto
        string datae;//data di erogazione
        string datas;//data di scadenza
        bool guida;//con o senza guida
        bool ridotto;//se è ridotto o no
        double prezzo;//prezzo biglietto

        public Biglietto(int cod, string date, string dates, bool gui,bool sc, double price)//costruttore 
        {
            code = cod; datae = date; datas = dates; guida = gui;ridotto = sc;prezzo = price;


        }
        public string vibi(int mode)//mode è la modalita 0== visualizza normale,1==visualizza per il pc
        {
            if (mode == 0) { return "codice : " + code + " data erogazione : " + datae + " data scadenza : " + datas + " con la guida : " + guida + " ridotto : " + ridotto + " prezzo : " + prezzo; }
            if (mode == 1) { return code + "-" + datae + "-" + datas + "-" + guida+"-"+ridotto+"-"+prezzo; }
            return "error";

        }
    }
}
