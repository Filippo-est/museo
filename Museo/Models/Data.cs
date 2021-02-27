using System;
using System.Collections.Generic;
using System.Text;

namespace Museo.Models
{
    class Data//da aggiungere nomi dei giorni,contagiorni giornata di oggi,
    {
        private int _giorno;
        private int _mese;
        private int _anno;
        public bool bis = false;
        

        public int giorno   // property
        {
            get { return _giorno; }   // get method
            set { _giorno = value; }
            // set method
        }
        public int mese   // property
        {
            get { return _mese; }   // get method
            set { _mese = value; }  // set method
        }
        public int anno   // property
        {
            get { return _anno; }   // get method
            set { _anno = value; }  // set method
        }

       
        public Data()//fine a se stessa
        {}
        public bool insdata(int day,int month,int year)
        {

            int check = 0, bis = 0;

            if (year < 0) { return false; }
            if (year >= 1582)
            { check = 1; }
            

            if (check == 1)
            {
                if (year % 4 == 0)
                {
                    if (year % 100 != 0)
                    {
                        bis = 1;
                    }
                    else
                    {
                        if (year % 400 == 0)
                        {
                            bis = 1;
                        }
                    }
                }

            }

           
            if (month < 1 || month > 12) { return false; }
           
           
            int limitem;
            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12) { limitem = 31; }
            else if (month == 2) { if (bis == 1) { limitem = 29; } else { limitem = 28; } }
            else { limitem = 30; }
            if (day < 1 || day > limitem) { return false; }
              _giorno = day; _mese = month; _anno = year;
            return true;
        }
        public void insdata()
        {

            int check = 0, bis = 0;
            Console.WriteLine("Inserisci l'anno sappi che se ne inserisci uno  inferiore a 1582 non potrò sapere se è bisestile");
            int ann = Convert.ToInt32(Console.ReadLine());
            while (ann < 0)
            {
                Console.WriteLine("non si accettano anni dietro l'anno zero (politica aziendale)");
                ann = Convert.ToInt32(Console.ReadLine());
            }
            if (ann >= 1582)
            { check = 1; }
            else { Console.WriteLine("Impossibile verificare se l'anno è bisestile"); }

            if (check == 1)
            {
                if (ann % 4 == 0)
                {
                    if (ann % 100 != 0)
                    {
                        bis = 1;
                    }
                    else
                    {
                        if (ann % 400 == 0)
                        {
                            bis = 1;
                        }
                    }
                }

            }

            if (bis == 1)
            { Console.WriteLine("Interessante.... , l'anno inserito è bisestile ricorda che gli anni bisestili hanno un giorno extra"); }
            Console.WriteLine("questa è facile, inserisci il mese, sai che sono 12 vero?");
            int mes = Convert.ToInt32(Console.ReadLine());
            while (mes < 1 || mes > 12)
            {
                Console.WriteLine("Hai inserito un mese sbagliato apposta vero? inseriscine uno tra 1 e 12 non ne conosco altri fuori da questo range");
                mes = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("oK ora arriva la parte difficile (per me) , inserisci i giorni basandoti sul mese inserito e se l'anno inserito è bisestile");
            int giorn = Convert.ToInt32(Console.ReadLine());
            int limitem;
            if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12) { limitem = 31; }
            else if (mes == 2) { if (bis == 1) { limitem = 29; } else { limitem = 28; } }
            else { limitem = 30; }
            while (giorn < 1 || giorn > limitem)
            {
                Console.WriteLine("Il giorno inserito è sbagliato controlla se l'anno è bisestile e regolati con i mesi ,mettine uno tra 1 e 28 per esserne sicuro");
                giorn = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Tutti i valori sono stati inseriti correttamente ");
            _giorno = giorn;_mese = mes;_anno = ann;
        }
        public void bisestile()
        {

            if (anno >= 1582)
            {
                if (anno % 4 == 0)
                {
                    if (anno % 100 != 0)
                    {
                        bis = true;
                    }
                    else
                    {
                        if (anno % 400 == 0)
                        {
                            bis = true;
                        }
                    }
                }

            }
        }
        public int contagiorni()
        { return 0; }
        public void aggiungigiorni(int giorni)
        {

            int limitem;
            if (mese == 1 || mese == 3 || mese == 5 || mese == 7 || mese == 8 || mese == 10 || mese == 12) { limitem = 31; }
            else if (mese == 2) { if (bis == true) { limitem = 29; } else { limitem = 28; } }
            else { limitem = 30; }
            giorno = giorno + giorni;
            while (giorno > limitem)
            {
                if (mese == 1 || mese == 3 || mese == 5 || mese == 7 || mese == 8 || mese == 10 || mese == 12) { limitem = 31; }
                else if (mese == 2) { if (bis == true) { limitem = 29; } else { limitem = 28; } }
                else { limitem = 30; }
                if (giorno > limitem) { mese++; giorno = giorno - limitem; }
                if (mese > 12) { mese = mese - 12; anno++; }
                bisestile();

            }
            if (giorno == 0) { giorno = 1; }


        }
        public void togligiorni(int giorni)
        {

            int limitem;
            if (mese == 1 || mese == 3 || mese == 5 || mese == 7 || mese == 8 || mese == 10 || mese == 12) { limitem = 31; }
            else if (mese == 2) { if (bis == true) { limitem = 29; } else { limitem = 28; } }
            else { limitem = 30; }
            giorno = giorno - giorni;
            if (giorno < 0) { giorno--; }
            while (giorno <= 0)
            {
                if (mese == 1 || mese == 3 || mese == 5 || mese == 7 || mese == 8 || mese == 10 || mese == 12) { limitem = 31; }
                else if (mese == 2) { if (bis == true) { limitem = 29; } else { limitem = 28; } }
                else { limitem = 30; }

                if (giorno < 0) { mese--; giorno = giorno + limitem; }
                if (giorno == 0) { giorno = 1; }
                if (mese == 0) { mese = mese + 12; anno--; }
                bisestile();
                if (giorno == 0) { giorno = 1; }

            }


        }
        public  string ToString(string tipo,string formato)
        {
            string s = "";

            if (formato == "IT")
            {
                s = ("giorno :" + giorno + " mese :" + mese + " anno :" + anno);
            }
            else if (formato == "US")
            {
                s = ("mese :" + mese + " giorno :" + giorno + " anno :" + anno);
            }
            else
            {
                s = ("anno: " + anno + " mese :" + mese + " giorno :" + giorno);
            }
            if (bis == true) { s = s + " è bisestile"; }
            return s;

        }
    }
}
