using System;

namespace Database.Models
{
    [Serializable]
    public class OcenaClass : ObservableObject
    {
        private string _OcenaKategoria;
        public string OcenaKategoria
        {
            get
            {
                if (string.IsNullOrEmpty(_OcenaKategoria))
                {
                    _OcenaKategoria=  Database.AllLangs.LangPL.PLTypyOcen()[0];
                }
                return _OcenaKategoria;
            }
            set
            {
                _OcenaKategoria = value;
                OnPropertyChanged("OcenaKategoria");
                
            }
        }
        private string _OcenaNazwa;
        public string OcenaNazwa
        {
            get
            {
                if (string.IsNullOrEmpty(_OcenaNazwa))
                {
                    _OcenaNazwa = Database.AllLangs.Lists.ListOcenString()[0];
                }
                return _OcenaNazwa;
            }
            set
            {

                _OcenaNazwa = value;
                OnPropertyChanged("OcenaNazwa");
            
            }
        }
        private int _OcenaWaga;
        public int OcenaWaga
        {
            get
            {
                if (_OcenaWaga == 0)
                {
                    return 0;
                }
                return _OcenaWaga;
            }
            set
            {

                _OcenaWaga = value;
                OnPropertyChanged("OcenaWaga");
               
            }
        }
       
    }


}
