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

namespace EF_WPF_DB_DEMO
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CapgeminiEntities dbCon = new CapgeminiEntities();
            Donor d1 = new Donor();
            d1.DonorID = 800;
            d1.BloodGrp = "A+";
            d1.Name = "Dummy";
            d1.City = "Hyd";
            dbCon.Donors.Add(d1);
            dbCon.SaveChanges();
            System.Windows.Forms.MessageBox.Show("Record Inserted");
        }
    }
}
