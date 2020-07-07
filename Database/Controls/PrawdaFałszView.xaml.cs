using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Database
{
    [Serializable]
    public partial class PrawdaFałszView : UserControl
    {
        public static DependencyProperty _IsCheck
     = DependencyProperty.Register(
           "IsCheck",
           typeof(bool),
           typeof(PrawdaFałszView),
           new PropertyMetadata(new PropertyChangedCallback(IscheckChanged))
       );
        private static void IscheckChanged(DependencyObject d,
         DependencyPropertyChangedEventArgs e)
        {
            PrawdaFałszView UserControl1Control = d as PrawdaFałszView;
            UserControl1Control.IscheckChanged(e);
        }

        private void IscheckChanged(DependencyPropertyChangedEventArgs e)
        {
            BitmapImage src1 = new BitmapImage();
            src1.BeginInit();
            src1.DecodePixelWidth = 50;

            if ((bool)GetValue(_IsCheck))
            {
                src1.UriSource = new Uri("UP.png", UriKind.Relative);
            }
            else
            {
                src1.UriSource = new Uri("Down.png", UriKind.Relative);
            }


            Obraz.Source = src1;
            src1.CacheOption = BitmapCacheOption.OnLoad;
            src1.EndInit();
        }
        public bool IsCheck
        {
            get => (bool)GetValue(_IsCheck);
            set => SetValue(_IsCheck, value);
        }
        public PrawdaFałszView()
        {
            InitializeComponent();

        }



        private void Obraz_Loaded(object sender, RoutedEventArgs e)
        {
            BitmapImage src1 = new BitmapImage();
            src1.BeginInit();

            src1.DecodePixelWidth = 50;
            if ((bool)GetValue(_IsCheck))
            {
                src1.UriSource = new Uri("UP.png", UriKind.Relative);
            }
            else
            {
                src1.UriSource = new Uri("Down.png", UriKind.Relative);
            }


            Obraz.Source = src1;
            src1.CacheOption = BitmapCacheOption.OnLoad;
            src1.EndInit();
        }

    }


}
