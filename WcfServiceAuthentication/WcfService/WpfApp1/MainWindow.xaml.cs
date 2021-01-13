using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Security;
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
        }
        

      

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            
            if (string.IsNullOrEmpty(valueAtb.Text) && string.IsNullOrEmpty(valueBtb.Text))
            {
                MessageBox.Show("Wpisz wartości liczbowe w odpowiednie pola");
            }
            else
            {
                ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
                client.ClientCredentials.UserName.UserName = "test";
                client.ClientCredentials.UserName.Password = "test";
                client.ClientCredentials.ServiceCertificate.Authentication.CertificateValidationMode = X509CertificateValidationMode.PeerTrust;
                resulttb.Text = client.Add(int.Parse(valueAtb.Text), int.Parse(valueBtb.Text)).ToString();
            }
               // resulttb.Text = client.Add(int.Parse(valueAtb.Text), int.Parse(valueBtb.Text)).ToString();
        }

        private void substrattb_Click(object sender, RoutedEventArgs e)
        {
            if(string.IsNullOrEmpty(valueAtb.Text) && string.IsNullOrEmpty(valueBtb.Text))
            {
                MessageBox.Show("Wpisz wartości liczbowe w odpowiednie pola");
            }
            else
            {
                ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
                client.ClientCredentials.UserName.UserName = "testi";
                client.ClientCredentials.UserName.Password = "test";
                client.ClientCredentials.ServiceCertificate.Authentication.CertificateValidationMode = X509CertificateValidationMode.None;
                resulttb.Text = client.Substrat(int.Parse(valueAtb.Text), int.Parse(valueBtb.Text)).ToString();
            }

        }

 
    }
}
