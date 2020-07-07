using System;
using System.Collections.ObjectModel;

namespace Database.Models
{
    [Serializable]
    public class PrzedmiotClass : ObservableObject
    {

        private string _PrzedmiotNazwa;
        private ObservableCollection<OcenaClass> _PrzedmiotOceny1;
        private ObservableCollection<OcenaClass> _PrzedmiotOceny2;
        private double _PrzedmiotŚrednia;
        private double _PrzedmiotŚrednia1;
        private double _PrzedmiotŚrednia2;
        private string _PrzedmiotProg;
        private bool _PrzedmiotIsBranyPodUwage;
        private int _PrzedmiotOcena;
        private int _PrzedmiotOcena1;
        private int _PrzedmiotOcena2;






        public string PrzedmiotNazwa
        {
            get
            {
                return _PrzedmiotNazwa;
            }
            set
            {
                _PrzedmiotNazwa = value;
                OnPropertyChanged("PrzedmiotNazwa");
            }
        }
        public ObservableCollection<OcenaClass> PrzedmiotOceny1
        {
            get
            {

              
                if (_PrzedmiotOceny1 == null)
                {
                    _PrzedmiotOceny1 = new ObservableCollection<OcenaClass>();
                   
                }
              
                return _PrzedmiotOceny1;
            }
            set
            {

             
                _PrzedmiotOceny1 = value;

               
                OnPropertyChanged("PrzedmiotOceny1");


            }
        }
        public ObservableCollection<OcenaClass> PrzedmiotOceny2
        {
            get
            {


                if (_PrzedmiotOceny2 == null)
                {
                    _PrzedmiotOceny2 = new ObservableCollection<OcenaClass>();

                }
             
                return _PrzedmiotOceny2;
            }
            set
            {


                _PrzedmiotOceny2 = value;
           

                OnPropertyChanged("PrzedmiotOceny2");


            }
        }
        public double PrzedmiotŚrednia
        {
            get
            {
                if (_PrzedmiotŚrednia == double.NaN)
                {
                    _PrzedmiotŚrednia = 0;
                }
                return _PrzedmiotŚrednia;
            }
            set
            {
                if (value == double.NaN)
                {
                    _PrzedmiotŚrednia = 0;
                }

                _PrzedmiotŚrednia = value;
                OnPropertyChanged("PrzedmiotŚrednia");
            }
        }
        public double PrzedmiotŚrednia1
        {
            get
            {
                if (_PrzedmiotŚrednia1 == double.NaN)
                {
                    _PrzedmiotŚrednia1 = 0;
                }
                return _PrzedmiotŚrednia1;
            }
            set
            {
                if (value == double.NaN)
                {
                    _PrzedmiotŚrednia1 = 0;
                }

                _PrzedmiotŚrednia1 = value;
                OnPropertyChanged("PrzedmiotŚrednia1");
            }
        }
        public double PrzedmiotŚrednia2
        {
            get
            {
                if (_PrzedmiotŚrednia2 == double.NaN)
                {
                    _PrzedmiotŚrednia2 = 0;
                }
                return _PrzedmiotŚrednia2;
            }
            set
            {
                if (value == double.NaN)
                {
                    _PrzedmiotŚrednia2 = 0;
                }

                _PrzedmiotŚrednia2 = value;
                OnPropertyChanged("PrzedmiotŚrednia2");
            }
        }
        public string PrzedmiotProg
        {
            get
            {


                if (string.IsNullOrEmpty(_PrzedmiotProg))
                {
                    _PrzedmiotProg =  Database.AllLangs.LangPL.PLTypyNauczycieli()[2];
                }

          


                return _PrzedmiotProg;
            }
            set
            {
                _PrzedmiotProg = value;
         
                OnPropertyChanged("PrzedmiotProg");

            }
        }
        public bool PrzedmiotIsBranyPodUwage
        {
            get => _PrzedmiotIsBranyPodUwage;
            set
            {
                _PrzedmiotIsBranyPodUwage = value;
                OnPropertyChanged("PrzedmiotIsBranyPodUwage");
            }
        }
        public int PrzedmiotOcena
        {
            get => _PrzedmiotOcena;
            set
            {
                _PrzedmiotOcena = value;
                OnPropertyChanged("PrzedmiotOcena");

            }
        }
        public int PrzedmiotOcena1
        {
            get => _PrzedmiotOcena1;
            set
            {
                _PrzedmiotOcena1 = value;
                OnPropertyChanged("PrzedmiotOcena1");

            }
        }
        public int PrzedmiotOcena2
        {
            get => _PrzedmiotOcena2;
            set
            {
                _PrzedmiotOcena2 = value;
                OnPropertyChanged("PrzedmiotOcena2");

            }
        }
        public void ObliczSrednia()
        {
            try

            {
                double SumaWag = 0;
                double sumaSił = 0;
                foreach (OcenaClass item in _PrzedmiotOceny1)
                {
                    sumaSił += (Database.Functions.ZnajdzOcenę(item.OcenaNazwa) * item.OcenaWaga);
                    SumaWag += item.OcenaWaga;


                }
                double temp = 0;
                temp = (sumaSił / SumaWag);
                if (double.IsNaN(temp))
                {
                    PrzedmiotŚrednia1 = 0;
                    PrzedmiotOcena1 = 0;
                }
                else
                {

                    PrzedmiotŚrednia1 = temp;
                    PrzedmiotOcena1 = Database.Functions.OcenaNaKoniec(PrzedmiotProg, PrzedmiotŚrednia1);
                }
                SumaWag = 0;
                sumaSił = 0;
                temp = 0;
                foreach (OcenaClass item in _PrzedmiotOceny2)
                {
                    sumaSił += (Database.Functions.ZnajdzOcenę(item.OcenaNazwa) * item.OcenaWaga);
                    SumaWag += item.OcenaWaga;
                }
                temp = (sumaSił / SumaWag);
                if (double.IsNaN(temp))
                {
                    PrzedmiotŚrednia2 = 0;
                    PrzedmiotOcena2 = 0;
                }
                else
                {

                    PrzedmiotŚrednia2 = temp;
                    PrzedmiotOcena2 = Database.Functions.OcenaNaKoniec(_PrzedmiotProg, _PrzedmiotŚrednia2);
                }
                temp = 0;
                if (PrzedmiotŚrednia1 != 0 && PrzedmiotŚrednia2 != 0)
                {
                    temp = (PrzedmiotŚrednia1 + PrzedmiotŚrednia2) / 2;
                }
            
                if (temp == 0)
                {
                    PrzedmiotŚrednia = 0;
                    PrzedmiotOcena = 0;
                }
                else
                {
                    PrzedmiotŚrednia = temp;
                    PrzedmiotOcena= Database.Functions.OcenaNaKoniec(PrzedmiotProg, PrzedmiotŚrednia);
                }
             

            }
            catch (Exception)
            {
                PrzedmiotOcena = 0;
                PrzedmiotŚrednia = 0;
            }
        }
    }



}
