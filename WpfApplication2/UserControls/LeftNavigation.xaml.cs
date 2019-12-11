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
using WpfApplication2.View;
using WpfSampleApp;

namespace WpfApplication2.UserControls
{
    /// <summary>
    /// Interaction logic for LeftNavigation.xaml
    /// </summary>
    public partial class LeftNavigation : UserControl
    {
        public static readonly DependencyProperty ParentWindowProperty = DependencyProperty.Register("ParentWindow", typeof(Window), typeof(LeftNavigation));
        public Window ParentWindow
        {
            get { return GetValue(ParentWindowProperty) as Window; }
            set { SetValue(ParentWindowProperty, value); }
        }

        public LeftNavigation()
        {
            InitializeComponent();

            
        }

        private void Dashboard_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)ParentWindow).FrameArea.Navigate(new System.Uri("/View/Dashboard.xaml", UriKind.RelativeOrAbsolute));
        }

        private void Customer_Click(object sender, RoutedEventArgs e)
        {            
            ((MainWindow)ParentWindow).FrameArea.Navigate(new System.Uri("/View/Customer.xaml", UriKind.RelativeOrAbsolute));
        }

        private void Orders_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)ParentWindow).FrameArea.Navigate(new System.Uri("/View/Order.xaml", UriKind.RelativeOrAbsolute));
        }

        private void Profile_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)ParentWindow).FrameArea.Navigate(new System.Uri("/View/Profile.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}
