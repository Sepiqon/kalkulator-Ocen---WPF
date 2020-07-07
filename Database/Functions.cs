
using System;
using System.Collections.Generic;

namespace Database
{
    [Serializable]
    internal class Functions
    {
        public static double Obliczsrednia(List<double> ListaWartosc)
        {
            if (ListaWartosc.Count == 0) { return default; }
            double tymczasowe = default;
            foreach (double item in ListaWartosc) { tymczasowe += item; }
            tymczasowe /= ListaWartosc.Count;
            if (tymczasowe == double.NaN) { return default; } else { return tymczasowe; }
        }
        public static double ZnajdzOcenę(string ocena)
        {


            switch (ocena)
            {
                case "1":
                    return 1;
                    break;
                case "1+":
                    return 1.5;
                    break;
                case "2":
                    return 2;
                    break;
                case "2+":
                    return 2.5;
                    break;
                case "2-":
                    return 1.75;
                    break;
                case "3":
                    return 3;
                    break;
                case "3+":
                    return 3.5;
                    break;
                case "3-":
                    return 2.75;
                    break;
                case "4":
                    return 4;
                    break;
                case "4+":
                    return 4.5;
                    break;
                case "4-":
                    return 3.75;
                    break;
                case "5":
                    return 5;
                    break;
                case "5+":
                    return 5.5;
                    break;
                case "5-":
                    return 4.75;
                    break;
                case "6":
                    return 6;
                    break;
                case "6-":
                    return 5.75;
                    break;
            }
            return default;
            //double minus=0;
            //double plus=0;
            //int ocenaWlasciwa=0;
            //if (ocena.Replace("+", "") != ocena)
            //{
            //    plus = 0.5;
            //    ocenaWlasciwa = int.Parse(ocena.Replace("+", ""));
            //}

            //if (ocena.Replace("-", "") != ocena)
            //{
            //    minus = 0.25;
            //    ocenaWlasciwa = int.Parse(ocena.Replace("-", ""));
            //}
            //if (ocena.Replace("+", "") == ocena && ocena.Replace("-", "") == ocena)
            //{
            //    ocenaWlasciwa = int.Parse(ocena);
            //}
            //return ocenaWlasciwa + plus - minus;


        }
        public static int OcenaNaKoniec(string prog, double srednia)
        {
            List<double> SrednieSrednie = new List<double>
            {
                0,
                1.70,
                2.70,
                3.70,
                4.75,
                5.30
            };
            if (srednia == double.NaN)
            {
                return 0;
            }
            List<double> Srednie = new List<double>();
            foreach (double item in SrednieSrednie)
            {

                Srednie.Add(item + (((Database.AllLangs.LangPL.PLTypyNauczycieli().IndexOf(prog)) - 3) * 0.1));
            }
            foreach (double item in Srednie)
            {
                if (srednia < item)
                {
                    return Srednie.IndexOf(item);
                }
            }
            if (6 > Srednie[5])
            {
                return 6;
            }

            return default;

        }

    }
}
