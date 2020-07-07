using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Database.AllLangs
{
    [Serializable]
    public class LangPL
    {


        public static List<string> PLPrzedmioty()
        {

            List<string> tmp = new List<string>
            {
                "Biologia",//0
                "Chemia",//1
                "J. Polski",//2
                "Matematyka",//3
                "W-F",//4
                "Religia",//5
                "Plastyka",//6
                "J. Angielski",//7
                "J. Niemiecki",//8
                "J. Francuski",//9
                "J. Rosyjski",//10
                "Historia",//11
                "WOS",//12
                "Technika",//13
                "Zajęcia artystyczne",//14
                "Godzina wychowawcza",//15
                "Geografia",//16
                "Fizyka",//17
                "WDŻ",//18
                "EDB",//19
                "Informatyka",//20
                "Muzyka"//21
            };
            tmp.Sort();
            return tmp;

        }
        public static ObservableCollection<string> PLTypyOcen()
        {
            return new ObservableCollection<string>
            {
                "Sprawdzian",
                "Odpowiedź ustna",
                "Kartkówka",
                "Zadanie domowe",
                "Aktywność"
            };

        }
        public static List<string> PLTypyNauczycieli()
        {
            return new List<string> {
                "Niewymagający nauczyciel" ,
                "Mało wymagający nauczyciel",
                "Zwykły nauczyciel",
                "Wymagający nauczyciel",
                "Mega wymagający nauczyciel" };


        }

    }
}
