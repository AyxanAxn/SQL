using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        public ObservableCollection<Car> Cars { get; set; } = new ObservableCollection<Car>();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LoadWin window = new LoadWin(Cars);
            window.ShowDialog();         
        }
    }

    public class Car
    {
        public string Vendor { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public bool IsNew { get; set; }
    }

}
