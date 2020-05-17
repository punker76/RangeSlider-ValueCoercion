using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MahApps.Metro.Controls;

namespace RangeSlider_ValueCoercion
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty MaxValueDisplayedProperty = DependencyProperty.Register(
            "MaxValueDisplayed", typeof(double), typeof(MainWindow), new PropertyMetadata(75d, PropertyChangedCallback, CoerceValueCallback ));

        private static object CoerceValueCallback(DependencyObject dependencyObject, object baseValue)
        {
            var value = (double) baseValue;
            if (value < 50)
                return 50.0;
            return baseValue;
        }

        private static void PropertyChangedCallback(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs)
        {
        }

        public double MaxValueDisplayed
        {
            get { return (double) GetValue(MaxValueDisplayedProperty); }
            set { SetValue(MaxValueDisplayedProperty, value); }
        }
    }
}
