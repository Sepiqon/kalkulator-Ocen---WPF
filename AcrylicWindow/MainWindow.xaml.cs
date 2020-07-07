


using Database;
using Database.Models;
using Database;
using Database.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows;
using System.Windows.Threading;
using System.Xaml;
using System.Xml.Serialization;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Windows.Controls;
using System.Threading.Tasks;

namespace KalkuratorOcen

{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    [Serializable]
    public partial class MainWindow : Window
    {
        #region Zmienne

        public static SesjeClass SesjeClass = new SesjeClass ();
        public static readonly HeaderText HeaderTexttutaj = new HeaderText();
        public static int OcenaListaPrzedmiotowIndex = 0;
        public static bool bool2 = false;
        public static bool start = true;
        public static Dictionary<string, int> WagiKategorii = new Dictionary<string, int>();
        public static ObservableCollection<string> K { get=> Database.Listy.KategorieList; set { Database.Listy.KategorieList = value; } } 
        public static List<string> O { get; set; } = Database.AllLangs.Lists.ListOcenString();
        public static List<int> W { get; set; } = Database.AllLangs.Lists.ListaWag();
        public static List<string> N { get; set; } = Database.AllLangs.LangPL.PLTypyNauczycieli();
        public static System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
        #endregion Zmienne
        #region Clasa,Start

    public MainWindow()
    {
           
            if (File.Exists("Lists.bin"))
        {


            Database.Listy.PrzedmiotyList = Deserialize<Database.Listy>(File.Open("Lists.bin", FileMode.Open)).Przedmioty;
            Database.Listy.KategorieList = Deserialize<Database.Listy>(File.Open("Lists.bin", FileMode.Open)).Kategorie;

        } else
            {
                Database.Listy.PrzedmiotyList =  Database.AllLangs.LangPL.PLPrzedmioty();
                Database.Listy.KategorieList = Database.AllLangs.LangPL.PLTypyOcen();
            }
           
            DataContext = this;
         
           
           
            dispatcherTimer.Tick += dispatcherTimer_Tick;
            dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0, 10);
            dispatcherTimer.Start();
          

        }

    
     
        #endregion
        #region Timer

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            WindowCent.DataContext = SesjeClass;
            
          
            if (start)
            {
                WczytajSesje_Click(null,null);
                if (SesjeClass.Sesje.Count == 0)
                {
                    DodajSesje_Click(null, null);
                    start = false;
                }
                start = false;

            }
            
            #region DataBase
            if (Database.Listy.PrzedmiotyList == null || Database.Listy.PrzedmiotyList.Count == 0)
            { Database.Listy.PrzedmiotyList = Database.AllLangs.LangPL.PLPrzedmioty(); }
            if (Database.Listy.KategorieList == null || Database.Listy.KategorieList.Count == 0)
            { Database.Listy.KategorieList = Database.AllLangs.LangPL.PLTypyOcen(); }
            #endregion

            
           


        }
        #endregion
        #region SeliazizeDeserialize
        public static void Serialize<Object>(Object dictionary, Stream stream)
        {
            try // try to serialize the collection to a file
            {
                using (stream)
                {
                    // create BinaryFormatter
                    BinaryFormatter bin = new BinaryFormatter();
                    // serialize the collection (EmployeeList1) to file (stream)
                    bin.Serialize(stream, dictionary);
                }
            }
            catch (IOException)
            {
            }
        }

        public static Object Deserialize<Object>(Stream stream) where Object : new()
        {
            Object ret = CreateInstance<Object>();
            try
            {
                using (stream)
                {
                    // create BinaryFormatter
                    BinaryFormatter bin = new BinaryFormatter();
                    // deserialize the collection (Employee) from file (stream)
                    ret = (Object)bin.Deserialize(stream);
                }
            }
            catch (IOException)
            {
            }
            return ret;
        }
        // function to create instance of T
        public static Object CreateInstance<Object>() where Object : new()
        {
            return (Object)Activator.CreateInstance(typeof(Object));
        }
        #endregion
        #region Opcje(1(About))



        private void About_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Tworca :Mateusz P. | Powstałem 21.01.2020 (1.0.0.0.0) | Służę do obliczenia Tobię średniej z przedmiotu i średniej Semesteralnej, szacuję ocenę ,jąką da ci nauczyciel z danego przedmiotu. Zostałem napisany w C#");
            //wersja 1.0.0.0.1 w 22.01.2020

        }
        #endregion

        private async void Program_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
           await ZapiszSesje_Click(null,null);
        }

        private void DodajSesje_Click(object sender, RoutedEventArgs e)
        {
          if(SesjeClass.Sesje.Count < 10)
            {
                SesjeClass.Sesje.Add(NowaSesja());
                if (SesjeClass.Sesje.Count == 1)
                {
                    TabC.SelectedIndex = 0;
                }
                else
                {
                    TabC.SelectedIndex = SesjeClass.Sesje.Count - 1;
                }
            }
          else
            {
                MessageBox.Show("Nie możesz dodać więcej");
            }
           
        }

        private void UsunSesje_Click(object sender, RoutedEventArgs e)
        {
            if (SesjeClass.Sesje.Count != 1)
               SesjeClass.Sesje.Remove((SesjaClass)TabC.SelectedItem);
            else
                MessageBox.Show("Nie Mozesz tego usunac");
        }

        private async Task ZapiszSesje_Click(object sender, RoutedEventArgs e)
        {
          
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            XamlServices.Save("Dane programu.xaml", SesjeClass);
           


            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            MessageBox.Show(String.Format("Zapisano w  {0} milisekund",
            ts.Milliseconds / 10));
         
        }

        private void WczytajSesje_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SesjeClass = (SesjeClass)XamlServices.Load("Dane programu.xaml");
                WindowCent.DataContext = SesjeClass;
                InitializeComponent();
            }
            catch(Exception)
            {

            }
          
        }
        public static void WriteToJsonFile<T>(string filePath, T objectToWrite, bool append = false) where T : new()
        {
            TextWriter writer = null;
            try
            {
                var contentsToWriteToFile = JsonConvert.SerializeObject(objectToWrite);
                writer = new StreamWriter(filePath, append);
                writer.Write(contentsToWriteToFile);
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }
            
        }
        public static T ReadFromJsonFile<T>(string filePath) where T : new()
        {
            TextReader reader = null;
            try
            {
                reader = new StreamReader(filePath);
                var fileContents = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<T>(fileContents);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
        }
        private void PrawdaFałsz_Click(object sender, RoutedEventArgs e)
        {
          
            
            foreach (var item in ((SesjaClass)TabC.SelectedItem).Przedmioty)
            {
                item.PrzedmiotIsBranyPodUwage = ((PrawdaFałsz)sender).IsCheck;
            }

        }
        public static SesjaClass NowaSesja()
        {
            SesjaClass tmp = new SesjaClass();
            tmp.NameSesion = "Bez nazwy";
          
           // tmp.Semestry.Add
         
            
           
          
            foreach (var item in Database.Listy.PrzedmiotyList)
            {
                tmp.Przedmioty.Add(new PrzedmiotClass
                {
                    PrzedmiotIsBranyPodUwage = true,
                    PrzedmiotNazwa = item,
                    PrzedmiotProg= Database.AllLangs.LangPL.PLTypyNauczycieli()[2],
                    
                   
                }) ;
            }
          
            
            return tmp;


        }

        private void DataGrid_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            double sumaŚrednich1 = 0;
            double sumaŚrednich2 = 0;
            double sumaPrzedmiotow1 = 0;
            double sumaPrzedmiotow2 = 0;
            List<bool> LB= new List<bool>();
                
            foreach (var item in SesjeClass.SesjaObecna.Przedmioty)
            {

                item.ObliczSrednia();
                LB.Add(item.PrzedmiotIsBranyPodUwage);
                if (LB.Last())
                {
                    if (item.PrzedmiotŚrednia1 != 0)
                    {

                        sumaŚrednich1 += item.PrzedmiotOcena1;
                        sumaPrzedmiotow1++;

                    }
                    if (item.PrzedmiotŚrednia2 != 0)
                    {
                        sumaŚrednich2 += item.PrzedmiotOcena2;
                        sumaPrzedmiotow2++;
                    }
                }
            }
            if (sumaPrzedmiotow1 != 0)
            {
                SesjeClass.SesjaObecna.Średnia1 = sumaŚrednich1 / sumaPrzedmiotow1;
            }
            else
            {
                SesjeClass.SesjaObecna.Średnia1 = 0;
            }
            if (sumaPrzedmiotow2 != 0)
            {
                SesjeClass.SesjaObecna.Średnia2 = sumaŚrednich2 / sumaPrzedmiotow2;
            }
            else
            {
                SesjeClass.SesjaObecna.Średnia2 = 0;
            }
            if (sumaŚrednich1 != 0 && sumaŚrednich2 != 0)
            {
                SesjeClass.SesjaObecna.Średnia = (SesjeClass.SesjaObecna.Średnia1 + SesjeClass.SesjaObecna.Średnia2) / 2;
            }
            else
            {
                SesjeClass.SesjaObecna.Średnia = 0;
            }
        }

        private void DataGrid_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            double sumaŚrednich1 = 0;
            double sumaŚrednich2 = 0;
            double sumaPrzedmiotow1 = 0;
            double sumaPrzedmiotow2 = 0;
            List<bool> LB = new List<bool>();

            foreach (var item in SesjeClass.SesjaObecna.Przedmioty)
            {

                item.ObliczSrednia();
                LB.Add(item.PrzedmiotIsBranyPodUwage);
                if (LB.Last())
                {
                    if (item.PrzedmiotŚrednia1 != 0)
                    {

                        sumaŚrednich1 += item.PrzedmiotOcena1;
                        sumaPrzedmiotow1++;

                    }
                    if (item.PrzedmiotŚrednia2 != 0)
                    {
                        sumaŚrednich2 += item.PrzedmiotOcena2;
                        sumaPrzedmiotow2++;
                    }
                }


            }
            if (sumaPrzedmiotow1 != 0)
            {
                SesjeClass.SesjaObecna.Średnia1 = sumaŚrednich1 / sumaPrzedmiotow1;
            }
            else
            {
                SesjeClass.SesjaObecna.Średnia1 = 0;
            }
            if (sumaPrzedmiotow2 != 0)
            {
                SesjeClass.SesjaObecna.Średnia2 = sumaŚrednich2 / sumaPrzedmiotow2;
            }
            else
            {
                SesjeClass.SesjaObecna.Średnia2 = 0;
            }

            List<double> ListaOcenP1= new List<double>();
            List<double> ListaOcenP2 = new List<double>();

            if (sumaŚrednich1 != 0 && sumaŚrednich2 != 0)
            {
                
                SesjeClass.SesjaObecna.Średnia = (SesjeClass.SesjaObecna.Średnia1 + SesjeClass.SesjaObecna.Średnia2) / 2;
            }
            else
            {
                SesjeClass.SesjaObecna.Średnia = 0;
            }
        }
    }
}

