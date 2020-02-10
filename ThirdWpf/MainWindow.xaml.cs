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

namespace ThirdWpf
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RadioButton_1(object sender, RoutedEventArgs e)
        {
            Tab2.IsSelected = true;
        }
        private void RadioButton_2(object sender, RoutedEventArgs e)
        {
            Tab2.IsEnabled = false;
        }
        private void RadioButton_3(object sender, RoutedEventArgs e)
        {
            Tab2.IsEnabled = true;
        }
        private void RadioButton_4(object sender, RoutedEventArgs e)
        {
            Tab3.IsSelected = true;
        }
        private void TabControl(object sender, SelectionChangedEventArgs e)
        {
            TabControl tabControl = (TabControl)sender;
            TabItem tabItem = tabControl.SelectedItem as TabItem;
            switch(tabItem.Header)
            {
                case "Expander":
                    MessageBox.Show("Work");
                    break;
            }
        }
    }
}
