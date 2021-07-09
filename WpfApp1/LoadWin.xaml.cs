using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for LoadWin.xaml
    /// </summary>
    public partial class LoadWin : Window
    {
        public ObservableCollection<Car> Cars { get; set; }

        public LoadWin(ObservableCollection<Car> cars)
        {
            InitializeComponent();
            Cars = cars;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Car car = new Car
            {
                Vendor = vendor.Text,
                Model = model.Text,
                Year = int.Parse(year.Text),
                IsNew = isNew.Text == "Yes"

            };

            Cars.Add(car);

            System.Windows.MessageBox.Show(Cars[Cars.Count - 1].Vendor);

            this.Close();

            vendor.Text = model.Text = year.Text = isNew.Text = default;
            
        }
    }
}
