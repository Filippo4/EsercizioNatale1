using System;
using System.Collections.Generic;
using System.IO;
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

namespace EsercizioNatale1
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

        private void btn_aggiungi_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Visualizza_Click(object sender, RoutedEventArgs e)
        {
            List<string> nomi = new List<string>();
            List<double> voti = new List<double>();
            StreamReader sr = new StreamReader("FileInvalido.txt");
            string line;
            while ((line = sr.ReadLine())!= null)
            {
                int index = line.IndexOf(",");
                string nome = line.Substring(0, index);
                string voto = line.Substring(index + 1);

            }
             



        }
    }
}
