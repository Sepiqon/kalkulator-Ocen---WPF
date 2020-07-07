using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Database.Models
{
    [Serializable]
    public class SesjaClass : ObservableObject
    {
    
        private int _IndexSemestr;
        private string _NameSesion;
        private double _Średnia;

             public double Średnia
        {
            get
            {
                if (_Średnia == double.NaN)
                {
                    _Średnia = 0;
                }
                return _Średnia;
            }
            set
            {
                if (value == double.NaN)
                {
                    _Średnia = 0;
                }

                _Średnia = value;
                OnPropertyChanged("Średnia");
            }
        }
        private double _Średnia1;

        public double Średnia1
        {
            get
            {
                if (_Średnia1 == double.NaN)
                {
                    _Średnia1 = 0;
                }
                return _Średnia1;
            }
            set
            {
                if (value == double.NaN)
                {
                    _Średnia1 = 0;
                }

                _Średnia1 = value;
                OnPropertyChanged("Średnia1");
            }
        }
        private double _Średnia2;

        public double Średnia2
        {
            get
            {
                if (_Średnia2 == double.NaN)
                {
                    _Średnia2 = 0;
                }
                return _Średnia2;
            }
            set
            {
                if (value == double.NaN)
                {
                    _Średnia2 = 0;
                }

                _Średnia2 = value;
                OnPropertyChanged("Średnia2");
            }
        }
        public string NameSesion
        {
            get
            {
                
                return _NameSesion;
            }
            set
            {
                _NameSesion = value;
                OnPropertyChanged("NameSesion");
            }
        }
        public int IndexSemestr
        {
            get
            {
                return _IndexSemestr;
            }
            set
            {
                _IndexSemestr = value;
                OnPropertyChanged("IndexSemestr");
                OnPropertyChanged("SemesterObecny");
            }

        }
        private ObservableCollection<PrzedmiotClass> _Przedmioty;
        public ObservableCollection<PrzedmiotClass> Przedmioty
        {
            get
            {
                if (_Przedmioty == null)
                {
                    _Przedmioty = new ObservableCollection<PrzedmiotClass>();
                }
                return _Przedmioty;
            }
            set
            {
                _Przedmioty = value;
                OnPropertyChanged("Przedmioty");
            }
        }




    }
}
