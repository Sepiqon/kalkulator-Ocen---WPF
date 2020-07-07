using Database.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Database
{



  
    [Serializable]
    public class Listy
    {

        public List<string> Przedmioty { get; set; }
        public ObservableCollection<string> Kategorie { get; set; }
        public static List<string> PrzedmiotyList = new List<string>();
        public static ObservableCollection<string> KategorieList = new ObservableCollection<string>();

    }
}
