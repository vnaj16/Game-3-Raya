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
using System.Windows.Shapes;

namespace Game_3_in_Raya
{
    /// <summary>
    /// Interaction logic for Window_CambioTurnos.xaml
    /// </summary>
    public partial class Window_CambioTurnos : Window
    {
        public int Turno = 2;
        public Window_CambioTurnos(string N1, string N2)
        {
            InitializeComponent();

            B1.Content = N1;
            B2.Content = N2;
        }

        private void B1_Click(object sender, RoutedEventArgs e)
        {
            Turno = 1;
            this.Close();
        }

        private void B2_Click(object sender, RoutedEventArgs e)
        {
            Turno = 2;
            this.Close();
        }
    }
}
