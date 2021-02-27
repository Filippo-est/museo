using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Museo.Models
{
    class Verificabiglietto//classe per verificare i biglietti
    {
        int bverificati;//biglietti verificati
       

        public Verificabiglietto()//costruttore 
        {
           
            bverificati = 0;
        }

        public string verifica( Biglietto a)//verifica biglietto , richiesto in input oggetto biglietto
        {
           
            string inf = a.vibi(1);string[] inf2;
            inf2 = inf.Split("-");
            StreamReader sr = new StreamReader("data.txt");

            if(Convert.ToInt32(inf2[0])<999999&& Convert.ToInt32(inf2[0]) > 111111)//controlla codice
            {
                while(sr.EndOfStream)//controlla che non sia già stato validato
                {
                    if(sr.ReadLine()== inf2[0]) { return "biglietto già validato"; }
                }
                DateTime s = DateTime.ParseExact(inf2[2], "d-M-yyyy",System.Globalization.CultureInfo.InvariantCulture);//prende la data di scadenza
                DateTime now = DateTime.Today;//data attuale
                int check= DateTime.Compare(now, s);
                if (check == 0) { return "biglietto scaduto"; }//verifica che non sia scaduto
                else { return "biglietto valido "; }
            }
            else { return "biglietto non valido"; }
            
        }
    }
}
