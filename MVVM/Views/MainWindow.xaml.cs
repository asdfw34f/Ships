using Microsoft.Maps.MapControl.WPF;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;

namespace Ships.MVVM.Views
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            meMap.Focus();
            List<string> names = new List<string>() { "qwert", "zzzzz", "asdasd" };
            fromBox.ItemsSource = names;
            MapPolyline polyline = new MapPolyline() { Locations = new LocationCollection() { new Location(55.752004, 37.61773), new Location(55.752536, 37.604196) }, StrokeThickness = 10, Stroke = Brushes.Brown };
            meMap.Children.Add(polyline);
        }

        private void ComboBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            fromBox.IsDropDownOpen = true;
            // убрать selection, если dropdown только открылся
            var tb = (TextBox)e.OriginalSource;
            tb.Select(tb.SelectionStart + tb.SelectionLength, 0);
            CollectionView cv = (CollectionView)CollectionViewSource.GetDefaultView(fromBox.ItemsSource);
            cv.Filter = s =>
                ((string)s).IndexOf(fromBox.Text, StringComparison.CurrentCultureIgnoreCase) >= 0;
        }
    }
}
