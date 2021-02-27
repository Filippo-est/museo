using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Museo.Models
{
    class Erogabiglietti
    {
        int berogati;//biglietti erogati in totale
        int maxb;//biglietti massimi erogabili
        double prezzonormale;//prezzo biglietto
        double prezzoscontato;//prezzo biglietto scontato

        public Erogabiglietti(int max,double prezzo, double prezzos)//prezzo: prezzo biglietto prezzos: prezzo scontato
        {
            berogati = 0;
            if (max <= 0) { maxb = 1; }//piccolo controllo
            else { maxb = max; }
            prezzonormale = prezzo;
            prezzoscontato = prezzos;

          
        }

        public Biglietto erogatore(bool g,int age)
        {
            bool sconto=false; double costo;
            if (age <= 16) { sconto = true;costo = prezzoscontato; } else { costo = prezzonormale; }//assegna il prezzo del biglietto
            if (berogati == maxb) {  Biglietto b = new Biglietto(0, "", "", false,false,0);return b; }//restituisce un biglietto vuoto se raggiunta la quota di biglietti erogabili
            Random rnd = new Random();
            int c = rnd.Next(100000, 999999);//generatore codice
            DateTime now = DateTime.Today;//data attuale
            DateTime scadenza = DateTime.Today;
            scadenza.AddDays(14);//scadenza
            
            Biglietto a = new Biglietto(c, DateTime.Now.ToString("d/M/yyyy"),scadenza.ToString("d/M/yyyy"), g,sconto,costo);berogati++;//generazione biglietto
            return a;
        }

        
    }
}
