using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Database.Models
{
    [Serializable]
    public class SesjeClass:ObservableObject
    {
        private ObservableCollection<SesjaClass> _Sesje;
        public  ObservableCollection<SesjaClass> Sesje
        {
            get
            {
                if (_Sesje == null)
                {
                    _Sesje = new ObservableCollection<SesjaClass>();
                }
             
                return _Sesje;
            }
            set
            {
                _Sesje = value;
                OnPropertyChanged("Sesje");
                OnPropertyChanged("IndexSesjaObecna");
                OnPropertyChanged("SesjaObecna");
            }
        }
        private int _IndexSesjaObecna=-1;
        public int IndexSesjaObecna
        {
            get
            {
                
                return _IndexSesjaObecna;
            }
            set
            {
                _IndexSesjaObecna = value;
                OnPropertyChanged("IndexSesjaObecna");
                OnPropertyChanged("SesjaObecna");
            }
        }

        public SesjaClass SesjaObecna
        {
            get
            {
                if (_Sesje == null)
                {
                    _Sesje = new ObservableCollection<SesjaClass>();
                }
                if (_IndexSesjaObecna == -1)
                {
                    return null;
                }
                return _Sesje[_IndexSesjaObecna];

            }
            set
            {
                _Sesje[_IndexSesjaObecna] = value;
                OnPropertyChanged("SesjaObecna");
            }
        }


    }
}
